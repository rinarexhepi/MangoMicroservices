namespace Mango.Services.ProductAPI.Models.Dto
{
    //kur mundohemi me e thirre nje instance qe nuk ekziston na shfaqen keta parametra
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool? IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
