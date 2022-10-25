using System.ComponentModel.DataAnnotations;

namespace MVCResumePage.Models
{
    public class Work
    {
        public string WorkName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Duration { get; set; }
        public string Url { get; set; }

    }
    public class Education
    {
        public string EducationName { get; set; }
        public string InstitutionName { get; set; }
        [Range(1900, 3000)]
        public int StartYear { get; set; }
        [Range(1900,3000)]
        public int EndYear { get; set; }

    }
  /*  public class PortofolioUrl
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public List<string> Url { get; set; }
    }*/
   /* public class PortofolioPicUrl
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public List<string> Url { get; set; }
    }*/
    public class Biodata
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Email { get; set; }
        public string[,] Links { get; set; }
        public string ProfilePicUrl { get; set; }
        public List<string> Description { get; set; }
        public string[,] PortofolioUrl { get; set; }
        public List<Work> Work { get; set; }
        public List<Education> Education { get; set; }
        public string[,] Skill { get; set; } 
        public string[,] PortofolioPicUrl { get; set; }

    }
}
