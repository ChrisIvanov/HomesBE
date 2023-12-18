﻿using BuildingMarket.Images.Application.Contracts;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BuildingMarket.Images.Application.Features.Images.Commands.UploadPropertiesImages
{
    public class UploadPropertiesImagesCommandHandler(
        IPropertyImagesStore propertyImagesStore,
        IPropertyImagesRepository propertyImagesRepository,
        ILogger<UploadPropertiesImagesCommandHandler> logger)
        : IRequestHandler<UploadPropertiesImagesCommand>
    {
        private readonly IPropertyImagesRepository _propertyImagesRepository = propertyImagesRepository;
        private readonly ILogger<UploadPropertiesImagesCommandHandler> _logger = logger;

        public async Task Handle(UploadPropertiesImagesCommand request, CancellationToken cancellationToken)
        {
            var properties = await _propertyImagesRepository.GetAllForAllProperties();

            if (properties.Any())
            {
                await propertyImagesStore.UploadPropertiesImages(properties);
            }
            else
            {
                _logger.LogInformation("There are no images for uploading");
            }
        }
    }
}
