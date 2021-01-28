﻿using System.Collections.Generic;

namespace Conversations.Domain.Entities
{
    public class Participant
    {
        public int Id { get; set; }
        public List<ConversationParticipant> ConversationParticipants { get; set; }
        public string Name { get; set; }
        public string PseudoName { get; set; }
    }
}