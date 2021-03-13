using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Film_library
{
    public static class Seeder
    {
        public static void SeedDatabase(MyContext context)
        {
            
            SeedFilm(context);

            SeedFilter(context);
        }
        #region фильмы
        private static void SeedFilm(MyContext context)
        {
            if (context.Films.Count() == 0)
            {
                context.Films
                    .Add(new Film 
                    { 
                        Name = "Крестный отец",
                        Director="Френсис Коппала",
                        Genre="Кримнал",
                        Rating=10
                    });
                context.Films
                     .Add(new Film
                     {
                         Name = "Список Шиндлера",
                         Director = "Стивен Спилберг",
                         Genre = "Исторический",
                         Rating = 9
                     });
                context.SaveChanges();
            }
        }
        #endregion

        #region Фильтры
        private static void SeedFilter(MyContext context)
        {
            #region tblFilterNames - Назви фільтрів
            string[] filterNames = { "Режисер" };
            foreach (var type in filterNames)
            {
                if (context.FilterNames.SingleOrDefault(f => f.Name == type) == null)
                {
                    context.FilterNames.Add(
                        new FilterName
                        {
                            Name = type
                        });
                    context.SaveChanges();
                }
            }
            #endregion

            #region tblFilterValues - Значення фільтрів
            List<string[]> filterValues = new List<string[]> 
            {
                new string [] { "Френсис Коппала", "Стивен Спилберг", "Ридли Скотт","Джеймс Кемерон" },
                
            };

            foreach (var items in filterValues)
            {
                foreach (var value in items)
                {
                    if (context.FilterValues
                        .SingleOrDefault(f => f.Name == value) == null)
                    {
                        context.FilterValues.Add(
                            new FilterValue
                            {
                                Name = value
                            });
                        context.SaveChanges();
                    }
                }
            }
            #endregion

            #region Групування фільтрів

            for (int i = 0; i < filterNames.Length; i++)
            {
                foreach (var value in filterValues[i])
                {
                    var nId = context.FilterNames
                        .SingleOrDefault(ben => ben.Name == filterNames[i]).Id;
                    var vId = context.FilterValues
                        .SingleOrDefault(f => f.Name == value).Id;
                    if (context.FilterNameGroups
                        .SingleOrDefault(f => f.FilterValueId == vId &&
                        f.FilterNameId == nId) == null)
                    {
                        context.FilterNameGroups.Add(
                            new FilterNameGroup
                            {
                                FilterNameId = nId,
                                FilterValueId = vId
                            });
                        context.SaveChanges();
                    }
                }
            }

            #endregion

            #region tblFilters -Фільтри
            Filter[] filters =
            {
                new Filter { FilterNameId = 1, FilterValueId=1, FilmId=1 },
                new Filter { FilterNameId = 2, FilterValueId=10, FilmId=1 },

                new Filter { FilterNameId = 1, FilterValueId=2, FilmId=2 },
                new Filter { FilterNameId = 2, FilterValueId=9, FilmId=2 }
            };
            foreach (var item in filters)
            {
                var f = context.Filters.SingleOrDefault(p => p == item);
                if (f == null)
                {
                    context.Filters.Add(new Filter { FilterNameId = item.FilterNameId, FilterValueId = item.FilterValueId, FilmId = item.FilmId });
                    context.SaveChanges();
                }
            }
            #endregion
        }

        #endregion
    }
}
