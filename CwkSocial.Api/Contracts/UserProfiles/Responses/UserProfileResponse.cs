namespace CwkSocial.Api.Contracts.UserProfiles.Requests
{
    public record BasicInformation
    {
        public Guid UserProfileId { get;  set; }
        public BasicInformation BasicInfo { get;  set; }
        public DateTime DateCreated { get;  set; }
        public DateTime LastModified { get;  set; }
    }
}
