using System;
using ObrasFai.Shared.Entities;
using ObrasFai.Domain.Scopes.Support;

namespace ObrasFai.Domain.Entities.Support
{
    public class Campus : EntityTwo
    {
        protected Campus() { }

        public Campus(string city){
            City = city;
        }

        public Int16 Id { get; set; }

        public string City { get; set; }

        public void Create()
        {
            if (!this.CreateCampusScopeIsValid())
                return;
        }

        public void Update(string city)
        {
            if (!this.EditCampusScopeIsValid(City))
                return;

            this.City = city;
        }
                
    }
}
