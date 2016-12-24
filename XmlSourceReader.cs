using Microsoft.Xna.Framework.Content;

namespace XmlSource
{
	public class XmlDocumentReader : ContentTypeReader<XmlSource>
	{
		/// <summary>
		/// Loads an imported xml file.
		/// </summary>
		protected override XmlSource Read(ContentReader input, XmlSource existingInstance)
		{
			return new XmlSource(input.ReadString());
		}
	}
}
