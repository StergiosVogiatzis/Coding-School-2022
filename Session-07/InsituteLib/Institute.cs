using System;

namespace InstituteLib
{
    [Serializable]
    public class Institute
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }
        public Institute(string name, int yearsInService)
        {
            Name = name;
            YearsInService = yearsInService;
            ID = Guid.NewGuid();
        }
    }
}
