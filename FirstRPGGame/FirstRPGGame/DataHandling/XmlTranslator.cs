using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FirstRPGGame.DataHandling
{
    public class XmlTranslator<T> : ISerialize<T>, IDeserialize<T>
    {
        private readonly ServerLog _logger = new ServerLog();

        private readonly object _fileLock = new object();

        public List<T> Deserialize()
        {
            lock (_fileLock) {
                List<T> result;
                XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));
                _logger.Log($"File accesed is name: {typeof(T)}");
                if(File.Exists(typeof(T).ToString()))
                {
                    if(File.ReadAllLines(typeof(T).ToString()).Length != 0)
                    {
                        FileStream reader = new FileStream(typeof(T).ToString(), FileMode.Open);
                        result = (List<T>)deserializer.Deserialize(reader);
                        reader.Close();
                    }
                    else
                    {
                        result = new List<T>();
                    }
                }
                else
                {
                    File.Create(typeof(T).ToString());
                    //throw new FileNotFoundException(typeof(T).ToString());
                    result = new List<T>();
                }
                return result;
             }
            
        }

        public void Serialize(List<T> serializeObject)
        {
            Type serializeType = typeof(List<T>);
            lock (_fileLock)
            {
                _logger.Log($"File created with name: {serializeType}");
            }
            List<T> storedList = new List<T>();
            if (File.Exists(typeof(T).ToString()) && new FileInfo(typeof(T).ToString()).Length != 0)
            {
                storedList = Deserialize();
            }

            if (storedList.Count != 0)
            {
                storedList = PrepareList(storedList, serializeObject);
            }
            else
            {
                storedList.AddRange(serializeObject);
            }
            Stream writer = new FileStream(typeof(T).ToString(), FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof (List<T>));
            serializer.Serialize(writer, storedList);
            writer.Close();
        }

        public List<T> PrepareList(List<T> originList, List<T> newList)
        {
            List<T> returnList = originList;
            List<T> tempList = new List<T>();
            tempList.AddRange(newList);
            foreach (var element in tempList)
            {
                var element1 = element;
                var currentIndex = originList.FindIndex(i => i.Equals(element1));
                if (currentIndex != -1)
                {
                    returnList[currentIndex] = element;
                    newList.Remove(element);
                }
            }
            returnList.AddRange(newList);
            return returnList;
        }
    }
}