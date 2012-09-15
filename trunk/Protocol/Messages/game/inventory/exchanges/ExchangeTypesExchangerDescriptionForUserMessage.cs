// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeTypesExchangerDescriptionForUserMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ExchangeTypesExchangerDescriptionForUserMessage : NetworkMessage
	{
		public const uint Id = 5765;
		public override uint MessageId
		{
			get
			{
				return 5765;
			}
		}
		
		public int[] typeDescription;
		
		public ExchangeTypesExchangerDescriptionForUserMessage()
		{
		}
		
		public ExchangeTypesExchangerDescriptionForUserMessage(int[] typeDescription)
		{
			this.typeDescription = typeDescription;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)typeDescription.Count());
			foreach (var entry in typeDescription)
			{
				writer.WriteInt(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			typeDescription = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(typeDescription as int[])[i] = reader.ReadInt();
			}
		}
	}
}