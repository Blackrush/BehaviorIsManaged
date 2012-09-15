// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionMark.xml' the '27/06/2012 15:55:14'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace BiM.Protocol.Types
{
	public class GameActionMark
	{
		public const uint Id = 351;
		public virtual short TypeId
		{
			get
			{
				return 351;
			}
		}
		
		public int markAuthorId;
		public int markSpellId;
		public short markId;
		public sbyte markType;
		public Types.GameActionMarkedCell[] cells;
		
		public GameActionMark()
		{
		}
		
		public GameActionMark(int markAuthorId, int markSpellId, short markId, sbyte markType, Types.GameActionMarkedCell[] cells)
		{
			this.markAuthorId = markAuthorId;
			this.markSpellId = markSpellId;
			this.markId = markId;
			this.markType = markType;
			this.cells = cells;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(markAuthorId);
			writer.WriteInt(markSpellId);
			writer.WriteShort(markId);
			writer.WriteSByte(markType);
			writer.WriteUShort((ushort)cells.Count());
			foreach (var entry in cells)
			{
				entry.Serialize(writer);
			}
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			markAuthorId = reader.ReadInt();
			markSpellId = reader.ReadInt();
			if ( markSpellId < 0 )
			{
				throw new Exception("Forbidden value on markSpellId = " + markSpellId + ", it doesn't respect the following condition : markSpellId < 0");
			}
			markId = reader.ReadShort();
			markType = reader.ReadSByte();
			int limit = reader.ReadUShort();
			cells = new Types.GameActionMarkedCell[limit];
			for (int i = 0; i < limit; i++)
			{
				(cells as GameActionMarkedCell[])[i] = new Types.GameActionMarkedCell();
				(cells as Types.GameActionMarkedCell[])[i].Deserialize(reader);
			}
		}
	}
}