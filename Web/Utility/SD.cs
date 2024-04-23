namespace Mango.Web.Utility
{
    public class SD
    {
        public static string RoomTypeAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }

        
        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public const string TokenCookie = "JWTToken";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        public enum ContentType
        {
            Json,
            MultipartFormData,
        }
    }
}
