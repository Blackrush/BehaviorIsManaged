// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'HouseToSellListMessage.xml' the '27/06/2012 15:55:03'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class HouseToSellListMessage : NetworkMessage
	{
		public const uint Id = 6140;
		public override uint MessageId
		{
			get
			{
				return 6140;
			}
		}
		
		public short pageIndex;
		public short totalPage;
		public Types.HouseInformationsForSell[] houseList;
		
		public HouseToSellListMessage()
		{
		}
		
		public HouseToSellListMessage(short pageIndex, short totalPage, Types.HouseInformationsForSell[] houseList)
		{
			this.pageIndex = pageIndex;
			this.totalPage = totalPage;
			this.houseList = houseList;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(pageIndex);
			writer.WriteShort(totalPage);
			writer.WriteUShort((ushort)houseList.Count());
			foreach (var entry in houseList)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			pageIndex = reader.ReadShort();
			if ( pageIndex < 0 )
			{
				throw new Exception("Forbidden value on pageIndex = " + pageIndex + ", it doesn't respect the following condition : pageIndex < 0");
			}
			totalPage = reader.ReadShort();
			if ( totalPage < 0 )
			{
				throw new Exception("Forbidden value on totalPage = " + totalPage + ", it doesn't respect the following condition : totalPage < 0");
			}
			int limit = reader.ReadUShort();
			houseList = new Types.HouseInformationsForSell[limit];
			for (int i = 0; i < limit; i++)
			{
				(houseList as Types.HouseInformationsForSell[])[i] = new Types.HouseInformationsForSell();
				(houseList as Types.HouseInformationsForSell[])[i].Deserialize(reader);
			}
		}
	}
}