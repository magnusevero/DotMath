using System;
using System.IO;
using System.Xml.Serialization;

namespace NoahMath.BaseClasses
{
	public static class Persister
	{
		public static void SerializeObject<T>(T toSerialize, String filename)
		{
			var xmlSerializer = new XmlSerializer(toSerialize.GetType());
			TextWriter textWriter = new StreamWriter(filename);

			xmlSerializer.Serialize(textWriter, toSerialize);
			textWriter.Close();
		}

		public static T DeSerializeObject<T>(T toDeSerialize, String filename)
		{
			var xmlSerializer = new XmlSerializer(toDeSerialize.GetType());
			var textReader = new StreamReader(filename);

			object deserialized = xmlSerializer.Deserialize(textReader);
			textReader.Close();
			return (T) deserialized;
		}
	}
}