namespace monolith_api_playground.Models
{
    public class Store
    {
        public string StorId { get; set; } = string.Empty; 
        public string? StorName { get; set; }       
        public string? StorAddress { get; set; }    
        public string? City { get; set; }           
        public string? State { get; set; }          
        public string? Zip { get; set; }            
    }
}
