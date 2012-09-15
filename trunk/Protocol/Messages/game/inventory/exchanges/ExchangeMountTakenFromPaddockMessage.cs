// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeMountTakenFromPaddockMessage.xml' the '27/06/2012 15:55:09'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeMountTakenFromPaddockMessage : NetworkMessage
	{
		public const uint Id = 5994;
		public override uint MessageId
		{
			get
			{
				return 5994;
			}
		}
		
		public string name;
		public short worldX;
		public short worldY;
		public string ownername;
		
		public ExchangeMountTakenFromPaddockMessage()
		{
		}
		
		public ExchangeMountTakenFromPaddockMessage(string name, short worldX, short worldY, string ownername)
		{
			this.name = name;
			this.worldX = worldX;
			this.worldY = worldY;
			this.ownername = ownername;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(name);
			writer.WriteShort(worldX);
			writer.WriteShort(worldY);
			writer.WriteUTF(ownername);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			name = reader.ReadUTF();
			worldX = reader.ReadShort();
			if ( worldX < -255 || worldX > 255 )
			{
				throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
			}
			worldY = reader.ReadShort();
			if ( worldY < -255 || worldY > 255 )
			{
				throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
			}
			ownername = reader.ReadUTF();
		}
	}
}