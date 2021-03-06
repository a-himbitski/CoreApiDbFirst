﻿using System.Collections.Generic;
using Core.Entities;

namespace Core
{
    public interface IDataProvider
    {
        IEnumerable<PersonAddress> GetPersonAdreses();

        IEnumerable<StateProvince> GetStateProvinces();

        IEnumerable<CountryRegion> GetCountryRegions();

        PersonAddress GetPersonAddress(int addressId);

        StateProvince GetStateProvince(int provinceId);

        void CreatePersonAddress(PersonAddress address);

        void CreateStateProvince(StateProvince province);

        void UpdateAddress(PersonAddress address);
        
        void UpdateStateProvince(StateProvince province);

        void DeleteAddress(int id);

        void DeleteStateProvince(int id);
    }
}