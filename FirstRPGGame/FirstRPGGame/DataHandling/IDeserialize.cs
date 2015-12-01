using System.Collections.Generic;

namespace FirstRPGGame.DataHandling
{
    public interface IDeserialize<T>
    {
        List<T> Deserialize();
    }
}