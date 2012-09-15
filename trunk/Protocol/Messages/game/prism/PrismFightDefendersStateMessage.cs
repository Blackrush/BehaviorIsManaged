// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismFightDefendersStateMessage.xml' the '27/06/2012 15:55:12'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class PrismFightDefendersStateMessage : NetworkMessage
	{
		public const uint Id = 5899;
		public override uint MessageId
		{
			get
			{
				return 5899;
			}
		}
		
		public double fightId;
		public Types.CharacterMinimalPlusLookAndGradeInformations[] mainFighters;
		public Types.CharacterMinimalPlusLookAndGradeInformations[] reserveFighters;
		
		public PrismFightDefendersStateMessage()
		{
		}
		
		public PrismFightDefendersStateMessage(double fightId, Types.CharacterMinimalPlusLookAndGradeInformations[] mainFighters, Types.CharacterMinimalPlusLookAndGradeInformations[] reserveFighters)
		{
			this.fightId = fightId;
			this.mainFighters = mainFighters;
			this.reserveFighters = reserveFighters;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(fightId);
			writer.WriteUShort((ushort)mainFighters.Count());
			foreach (var entry in mainFighters)
			{
				entry.Serialize(writer);
			}
			writer.WriteUShort((ushort)reserveFighters.Count());
			foreach (var entry in reserveFighters)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadDouble();
			int limit = reader.ReadUShort();
			mainFighters = new Types.CharacterMinimalPlusLookAndGradeInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(mainFighters as Types.CharacterMinimalPlusLookAndGradeInformations[])[i] = new Types.CharacterMinimalPlusLookAndGradeInformations();
				(mainFighters as Types.CharacterMinimalPlusLookAndGradeInformations[])[i].Deserialize(reader);
			}
			limit = reader.ReadUShort();
			reserveFighters = new Types.CharacterMinimalPlusLookAndGradeInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(reserveFighters as Types.CharacterMinimalPlusLookAndGradeInformations[])[i] = new Types.CharacterMinimalPlusLookAndGradeInformations();
				(reserveFighters as Types.CharacterMinimalPlusLookAndGradeInformations[])[i].Deserialize(reader);
			}
		}
	}
}