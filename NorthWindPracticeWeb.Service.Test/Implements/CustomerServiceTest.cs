using System;
using System.Linq;
using AutoFixture;
using AutoMapper;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthWindPracticeWeb.Repository.Interfaces;
using NorthWindPracticeWeb.Repository.Models;
using NorthWindPracticeWeb.Service.DTOs;
using NorthWindPracticeWeb.Service.Interface;
using NSubstitute;

namespace NorthWindPracticeWeb.Service.Test.Implements
{
    [TestClass]
    public class CustomerServiceTest
    {
        private IGenericRepository<Customers> CustomerRepository { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            CustomerRepository = Substitute.For<IGenericRepository<Customers>>();
        }

        private ICustomerService GetSystemUnderTest()
        {
            var sut = new CustomerService
            (
                CustomerRepository
            );
            return sut;
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("CustomerService")]
        [TestProperty("CustomerService", "GetCustomers")]
        public void GetCustomers_取得所有Customer資料_應為30筆()
        {
            //arrange (準備)
            var sut = GetSystemUnderTest();
            var fixture = new Fixture();
            var source = fixture.Build<Customers>()
                .OmitAutoProperties()
                .CreateMany(30)
                .AsQueryable();
            CustomerRepository.GetAll().ReturnsForAnyArgs(source);

            //act (執行)
            var actual = sut.GetCustomers();
            //assert (驗證)
            actual.Should().HaveCount(30);

        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("CustomerService")]
        [TestProperty("CustomerService", "CreateCustomer")]
        public void CreateCustomer_新增客戶資料_應不會拋出錯誤()
        {
            //arrange (準備)
            var sut = GetSystemUnderTest();
            var fixture = new Fixture();
            var dto = fixture.Build<CustomerDto>().Create();

            //act (執行)
            Action action = () => sut.CreateCustomer(dto);
            //assert (驗證)
            action.Should().NotThrow<Exception>();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("CustomerService")]
        [TestProperty("CustomerService", "EditCustomer")]
        public void EditCustomer_修改客戶資料_應不會拋出錯誤()
        {
            //arrange (準備)
            var sut = GetSystemUnderTest();
            var fixture = new Fixture();
            var source = fixture.Build<Customers>()
                .OmitAutoProperties()
                .CreateMany(30)
                .AsQueryable();
            var dto = fixture.Build<CustomerDto>().Create();
            CustomerRepository.Query(null).ReturnsForAnyArgs(source);
           
            //act (執行)
            Action action = () => sut.EditCustomer(dto);
            //assert (驗證)
            action.Should().NotThrow<Exception>();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("CustomerService")]
        [TestProperty("CustomerService", "GetCustomerById")]
        public void GetCustomerById_輸入CustomerID_應取得客戶資料()
        {
            //arrange (準備)
            var sut = GetSystemUnderTest();
            var fixture = new Fixture();
            var source = fixture.Build<Customers>()
                .OmitAutoProperties()
                .CreateMany(30)
                .AsQueryable();
            var dto = Mapper.Map<Customers, CustomerDto>(source.FirstOrDefault()) ;
            CustomerRepository.Query(null).ReturnsForAnyArgs(source);

            //act (執行)
            var actual = sut.GetCustomerById(dto.CustomerID);
            //assert (驗證)
            actual.Should().BeEquivalentTo(dto);
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("CustomerService")]
        [TestProperty("CustomerService", "DeleteCustomer")]
        public void DeleteCustomer_刪除客戶資料_應不會拋出錯誤()
        {
            //arrange (準備)
            var sut = GetSystemUnderTest();
            var fixture = new Fixture();
            var source = fixture.Build<Customers>()
                .OmitAutoProperties()
                .CreateMany(30)
                .AsQueryable();
            var dto = Mapper.Map<Customers, CustomerDto>(source.FirstOrDefault());
            CustomerRepository.Query(null).ReturnsForAnyArgs(source);

            //act (執行)
            Action action = () => sut.DeleteCustomer(dto.CustomerID);
            //assert (驗證)
            action.Should().NotThrow<Exception>();
        }
    }
}