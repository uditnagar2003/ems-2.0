﻿
namespace BaseLibrary.Entities
{
    public class Employee :BaseEntity
    {
        
        public string? CivilId { get; set; }
        public string? FileNumber { get; set; }
        public string? FullName { get; set; }
        public string? JobName { get; set; }
        public string? Address { get; set; }
        public string? TelephoneNumber { get; set; }
        public String? Photo {  get; set; }
        public string? Other {  get; set; }

        // Relationship : Many to One  with branch
       
        public Branch? Branch { get; set; }
        public int BranchId { get; set; }
        public Town? Town { get; set; }
        public int TownId { get; set; }
    }
}
