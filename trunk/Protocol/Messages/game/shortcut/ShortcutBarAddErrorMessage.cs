// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ShortcutBarAddErrorMessage.xml' the '27/06/2012 15:55:13'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ShortcutBarAddErrorMessage : NetworkMessage
	{
		public const uint Id = 6227;
		public override uint MessageId
		{
			get
			{
				return 6227;
			}
		}
		
		public sbyte error;
		
		public ShortcutBarAddErrorMessage()
		{
		}
		
		public ShortcutBarAddErrorMessage(sbyte error)
		{
			this.error = error;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(error);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			error = reader.ReadSByte();
			if ( error < 0 )
			{
				throw new Exception("Forbidden value on error = " + error + ", it doesn't respect the following condition : error < 0");
			}
		}
	}
}