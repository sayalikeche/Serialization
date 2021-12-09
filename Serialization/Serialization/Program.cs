using Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization binary = new BinarySerialization();
            //binary.Serialization();
            binary.Deserialization();
            JsonSerialization serialization = new JsonSerialization();
            serialization.JsonSerialization();
            serialization.JsonDeserialize();
        }
    }


}