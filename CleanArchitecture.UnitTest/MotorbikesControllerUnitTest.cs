using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Features.MotorbikeFeatures.Commands.CreateMotorbike;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Presentation.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;


namespace CleanArchitecture.UnitTest;

public  class MotorbikesControllerUnitTest
{
    [Fact]
    public async Task Create_ReturnsOkResult_WhenRequestIsValid()
    {
        var mediatorMock = new Mock<IMediator>();
        CreateMotorbikeCommand createMotorbikeCommand = new(
            "BMW", "SupeSpeed", 5000,20
            );

        MessageResponse response = new("Motorbike registered ");

        CancellationToken cancellationToken = new();

        mediatorMock.Setup(m => m.Send(createMotorbikeCommand, cancellationToken))
            .ReturnsAsync(response);

        MotorbikesController motorbikesController = new(mediatorMock.Object);

        //Act
        var result = await motorbikesController.Create(createMotorbikeCommand, cancellationToken);

        //Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsType<MessageResponse>(okResult.Value);

        Assert.Equal(response, returnValue);
        mediatorMock.Verify(m => m.Send(createMotorbikeCommand, cancellationToken), Times.Once);

    }
}
