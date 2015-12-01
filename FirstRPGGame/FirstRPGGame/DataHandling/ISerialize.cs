using System.Collections.Generic;

namespace FirstRPGGame.DataHandling
{
    public interface ISerialize<T>
    {
        void Serialize(List<T> objectToBeSerialized);
    }
}