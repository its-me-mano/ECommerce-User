using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using ECommerce_User.Entities.Model;

namespace ECommerce_User.Dbcontexts
{
    public class UserDetailsContext : DbContext
    {
        public UserDetailsContext(DbContextOptions<UserDetailsContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<RefSet> RefSets { get; set; }
        public DbSet<RefTerm> RefTerms { get; set; }
        public DbSet<SetRefTerm> SetRefTerms { get; set; }
        public DbSet<UPI> UPIS { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                FirstName = "Sakthi",
                LastName = "Vel",
                Password = "Hello@123",
                CreateBy = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now,
                role=Guid.Parse("c17dd8cd-ba7d-45bc-a4c1-a8d3bd58117c")
            },
            new User()
            {
                Id = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                FirstName = "Manoj",
                LastName = "Kumar",
                Password = "Hello@321",
                CreateBy = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                DateCreated = DateTime.Now,
                role=Guid.Parse("3601bfeb-1103-4f49-98ba-712f55cee042")
            }
            );
            modelBuilder.Entity<Address>().HasData(new Address()
            {
                UserId = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                Id = Guid.Parse("859a0577-76ad-49ef-a111-346e4f978a88"),
                Line1 = "hello",
                Line2 = "solunga",
                City = "madurai",
                StateName = "tamilnadu",
                ZipCode = "625002",
                Type = Guid.Parse("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                Country = Guid.Parse("1f1f245d-c63b-42f6-b592-49b5b16bf861"),
                CreateBy = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now
            },
            new Address()
            {
                UserId = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                Id = Guid.Parse("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                Line1 = "hello",
                Line2 = "solunga",
                City = "madurai",
                StateName = "tamilnadu",
                ZipCode = "625002",
                Type = Guid.Parse("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                Country = Guid.Parse("1f1f245d-c63b-42f6-b592-49b5b16bf861"),
                CreateBy = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                DateCreated = DateTime.Now

            }
            );

            modelBuilder.Entity<Phone>().HasData(new Phone()
            {
                UserId = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                Id = Guid.Parse("00793011-a986-49f0-879b-86023edaff46"),
                PhoneNumber = "8925250061",
                TypeId = Guid.Parse("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                CreateBy = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now
            },
            new Phone()
            {
                UserId = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                Id = Guid.Parse("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                PhoneNumber = "9488977667",
                TypeId = Guid.Parse("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                CreateBy = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                DateCreated = DateTime.Now
            }
            );

            modelBuilder.Entity<Email>().HasData(new Email()
            {
                UserId = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                Id = Guid.Parse("d019119e-245b-45d2-93df-b4cbbdfeac9f"),
                EmailAddress = "itsmemano123@gmail.com",
                TypeId = Guid.Parse("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                CreateBy = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                DateCreated = DateTime.Now
            },
            new Email()
            {
                UserId = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                Id = Guid.Parse("8c50f920-4b3a-4565-a8b6-0b635b429a98"),
                EmailAddress = "itsmemano@gmail.com",
                TypeId = Guid.Parse("abad70c5-11db-42f8-9e3a-487023f1b1cc"),
                CreateBy = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                DateCreated = DateTime.Now
            });
            modelBuilder.Entity<UPI>().HasData(new UPI()
            {
                Id = Guid.Parse("abf127e7-ff34-4ac1-9a95-083f70047d14"),
                UserId = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                UPIID = "1234567891@apl",
                CreateBy = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                DateCreated = DateTime.Now,
                type="gpay"
            },
            new UPI()
            {
                Id = Guid.Parse("43c85934-796f-4bee-b858-066d04a18f1d"),
                UserId = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                UPIID = "1234567821@apl",
                CreateBy = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                DateCreated = DateTime.Now,
                type="paytm"
            }
            );
            modelBuilder.Entity<Card>().HasData(new Card()
            {
                Id = Guid.Parse("ef5e2a13-0ea6-4c83-a6a3-571e6ae79c60"),
                UserId = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                CreateBy = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                DateCreated = DateTime.Now,
                CardholderName = "Keerthi varman",
                CardNumber = "123456789101",
                CVV = "123",
                type="visa"

            },
            new Card()
            {
                Id = Guid.Parse("491274fa-cb0e-459e-a5d1-f4b45a22349a"),
                UserId = Guid.Parse("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"),
                CreateBy = Guid.Parse("68417748-6864-4866-8d9b-b82ae29da396"),
                DateCreated = DateTime.Now,
                CardholderName = "RamPrasath",
                CardNumber = "123098456712",
                CVV = "321",
                type="razor"
            }
            );

            string path = @"C:\Users\Manoj\source\repos\ECommerce User\ECommerce User\Dbcontexts\RefSet.csv";
            string ReadCSV = File.ReadAllText(path);
            foreach (string csvRow in ReadCSV.Split("\n"))
            {
                if (!string.IsNullOrEmpty(csvRow))
                {
                    string[] csvCols = csvRow.Split(",");
                    RefSet refSet = new RefSet();
                    refSet.Id = Guid.Parse(csvCols[0].ToString());
                    refSet.Key = csvCols[1].ToString();
                    refSet.Description = csvCols[2].ToString();
                    refSet.CreateBy = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
                    refSet.DateCreated = DateTime.Now;
                    modelBuilder.Entity<RefSet>().HasData(refSet);
                }
            }
            string path1 = @"C:\Users\Manoj\source\repos\ECommerce User\ECommerce User\Dbcontexts\RefTerm.csv";
            string ReadCSV1 = File.ReadAllText(path1);
            foreach (string csvRow in ReadCSV1.Split("\n"))
            {
                if (!string.IsNullOrEmpty(csvRow))
                {
                    string[] csvCols = csvRow.Split(",");
                    RefTerm refTerm = new RefTerm();
                    refTerm.Id = Guid.Parse(csvCols[1].ToString());
                    refTerm.Key = csvCols[0].ToString();
                    refTerm.Description = csvCols[2].ToString();
                    refTerm.CreateBy = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
                    refTerm.DateCreated = DateTime.Now;
                    modelBuilder.Entity<RefTerm>().HasData(refTerm);

                }
            }

            string path2 = @"C:\Users\Manoj\source\repos\ECommerce User\ECommerce User\Dbcontexts\SetRefTerm.csv";
            string ReadCSV2 = File.ReadAllText(path2);
            foreach (string csvRow in ReadCSV2.Split("\n"))
            {
                if (!string.IsNullOrEmpty(csvRow))
                {
                    string[] csvCols = csvRow.Split(",");
                    SetRefTerm setRefTerm = new SetRefTerm();
                    setRefTerm.RefSetid = Guid.Parse(csvCols[0].ToString());
                    setRefTerm.ReftermId = Guid.Parse(csvCols[1].ToString());
                    setRefTerm.Id = Guid.Parse(csvCols[2].ToString());
                    setRefTerm.CreateBy = new Guid("68417748-6864-4866-8d9b-b82ae29da396");
                    setRefTerm.DateCreated = DateTime.Now;
                    modelBuilder.Entity<SetRefTerm>().HasData(setRefTerm);
                }
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
