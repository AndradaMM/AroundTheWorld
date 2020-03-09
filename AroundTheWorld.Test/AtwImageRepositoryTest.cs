using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.DataAccess.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AroundTheWorld.Test
{

    [TestClass]
    public class AtwImageRepositoryTest
    {
        [TestMethod]
        public void AddAtwImageTest()
        {
            //-- Arrange
            var random = new Random();
            var projectPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            AtwImage expected = new AtwImage
            {
                Id = random.Next(1_000_000, 2_000_000),
                Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/black-panther-background.jpg")),
                CreatedOn =new DateTime(2020,2,2)

            };

            var dbContextFactory = new AtwDbContextFactory();
            var dbContext = dbContextFactory.CreateDbContext(new string[0]);

            var atwImageRepository = new AtwImageRepository(dbContext);

            //-- Act
            atwImageRepository.Add(expected);
            atwImageRepository.SaveChanges();
            var actual = atwImageRepository.GetById(expected.Id);



            //--Assert
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Content, actual.Content);
            Assert.AreEqual(expected.CreatedOn, actual.CreatedOn);
            

            dbContext.Dispose();

        }
    }
}
