﻿using System.Threading.Tasks;
using QB.SeatAllocation.Models.TokenAuth;
using QB.SeatAllocation.Web.Controllers;
using Shouldly;
using Xunit;

namespace QB.SeatAllocation.Web.Tests.Controllers
{
    public class HomeController_Tests: SeatAllocationWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}