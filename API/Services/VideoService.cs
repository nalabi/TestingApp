using System;
using API.Entities;
using API.Options;
using Twilio;
using Twilio.Base;
using Twilio.Jwt.AccessToken;
using Twilio.Rest.Video.V1;
using Twilio.Rest.Video.V1.Room;
using ParticipantStatus = Twilio.Rest.Video.V1.Room.ParticipantResource.StatusEnum;

namespace API.Services
{
    public class VideoService : IVideoService
    {
         readonly TwilioSettings _twilioSettings;

        public VideoService(Microsoft.Extensions.Options.IOptions<TwilioSettings> twilioOptions)
        {
            _twilioSettings = twilioOptions?.Value
            ?? throw new ArgumentNullException(nameof(twilioOptions));

            TwilioClient.Init(_twilioSettings.ApiKey, _twilioSettings.ApiSecret);
        }

        public string GetTwilioJwt(string identity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<RoomDetails>> IVideoService.GetAllRoomsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
