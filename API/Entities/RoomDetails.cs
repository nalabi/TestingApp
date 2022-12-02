using System;

namespace API.Entities
{
    public record RoomDetails
    (
        string Id,
        string Name,
        int ParticipantCount,
        int MaxParticipants
    );     
    }

