using System;
using Xunit;
using System.Linq;
using Assignment2Data.Services;
using Assignment2Data.Animal;

namespace Assignment2Test
{
    public class AnimalServiceTests
    {
        private IAnimalDataService service;

        public AnimalServiceTests()
        {
            service = new AnimalDataService();
        }

        [Fact]
        public void TestSelectAll()
        {
            ServiceSeeder.Seed(service);

            var animals = service.SelectAll();
            var animalCount = animals.Count();

            Assert.Equal(6, animalCount);
        }

        [Fact]
        public void TestInsert()
        {
            ServiceSeeder.Seed(service);
            
            var animals = service.SelectAll();
            var beforeCount = animals.Count();

            var test = service.Insert(new Animals
            {
                AniName = "test",
                AniType = "test",
                AniBreed = "test",
                AniDoB = DateTime.Parse("01/01/2000"),
                AniDesc = "test",
                AniPic = "test"
            });

            animals = service.SelectAll();
            var afterCount = animals.Count();

            Assert.Equal(beforeCount+1, afterCount);
        }

        [Fact]
        public void TestDelete()
        {
            ServiceSeeder.Seed(service);
            
            var animals = service.SelectAll();
            var beforeCount = animals.Count();

            service.Delete(2);

            animals = service.SelectAll();
            var afterCount = animals.Count();

            Assert.Equal(beforeCount - 1, afterCount);
        }

        [Fact]
        public void TestUpdate()
        {
            ServiceSeeder.Seed(service);
            
            var beforeName = service.SelectByID(1);

            beforeName.AniName = "Test";

            service.Update(beforeName);
            
            var afterName = service.SelectByID(1);

            Assert.Equal("Test", afterName.AniName);
        }

        [Fact]
        public void TestDetails()
        {
            ServiceSeeder.Seed(service);

            var before = service.SelectByID(1);
            
            var after = service.SelectByID(1);

            Assert.Equal(before, after);
        }
    }
}
