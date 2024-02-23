﻿using ErrorOr;
using MediatR;

namespace Cimas.Application.Features.Cinemas.Commands.UpdateCinema
{
    public record UpdateCinemaCommand(
        Guid UserId,
        Guid CinemaId,
        string Name,
        string Adress
    ) : IRequest<ErrorOr<Success>>;
}
