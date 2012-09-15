// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildMemberWarnOnConnectionStateMessage.xml' the '27/06/2012 15:55:06'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class GuildMemberWarnOnConnectionStateMessage : NetworkMessage
	{
		public const uint Id = 6160;
		public override uint MessageId
		{
			get
			{
				return 6160;
			}
		}
		
		public bool enable;
		
		public GuildMemberWarnOnConnectionStateMessage()
		{
		}
		
		public GuildMemberWarnOnConnectionStateMessage(bool enable)
		{
			this.enable = enable;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(enable);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			enable = reader.ReadBoolean();
		}
	}
}