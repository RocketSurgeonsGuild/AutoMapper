﻿using System;
using AutoMapper;
using NodaTime;

namespace Rocket.Surgery.Extensions.AutoMapper.Converters
{
    /// <summary>
    /// Class LocalDateTimeConverter.
    /// Implements the <see cref="AutoMapper.ITypeConverter{NodaTime.LocalDateTime, System.DateTime}" />
    /// Implements the <see cref="AutoMapper.ITypeConverter{NodaTime.LocalDateTime?, System.DateTime?}" />
    /// Implements the <see cref="AutoMapper.ITypeConverter{System.DateTime, NodaTime.LocalDateTime}" />
    /// Implements the <see cref="AutoMapper.ITypeConverter{System.DateTime?, NodaTime.LocalDateTime?}" />
    /// </summary>
    /// <seealso cref="AutoMapper.ITypeConverter{NodaTime.LocalDateTime, System.DateTime}" />
    /// <seealso cref="AutoMapper.ITypeConverter{NodaTime.LocalDateTime?, System.DateTime?}" />
    /// <seealso cref="AutoMapper.ITypeConverter{System.DateTime, NodaTime.LocalDateTime}" />
    /// <seealso cref="AutoMapper.ITypeConverter{System.DateTime?, NodaTime.LocalDateTime?}" />
    public class LocalDateTimeConverter :
        ITypeConverter<LocalDateTime, DateTime>,
        ITypeConverter<LocalDateTime?, DateTime?>,
        ITypeConverter<DateTime, LocalDateTime>,
        ITypeConverter<DateTime?, LocalDateTime?>
    {
        /// <summary>
        /// Performs conversion from source to destination type
        /// </summary>
        /// <param name="source">Source object</param>
        /// <param name="destination">Destination object</param>
        /// <param name="context">Resolution context</param>
        /// <returns>Destination object</returns>
        public DateTime Convert(LocalDateTime source, DateTime destination, ResolutionContext context)
        {
            return source.ToDateTimeUnspecified();
        }

        /// <summary>
        /// Performs conversion from source to destination type
        /// </summary>
        /// <param name="source">Source object</param>
        /// <param name="destination">Destination object</param>
        /// <param name="context">Resolution context</param>
        /// <returns>Destination object</returns>
        public DateTime? Convert(LocalDateTime? source, DateTime? destination, ResolutionContext context)
        {
            return source?.ToDateTimeUnspecified();
        }

        /// <summary>
        /// Performs conversion from source to destination type
        /// </summary>
        /// <param name="source">Source object</param>
        /// <param name="destination">Destination object</param>
        /// <param name="context">Resolution context</param>
        /// <returns>Destination object</returns>
        public LocalDateTime Convert(DateTime source, LocalDateTime destination, ResolutionContext context)
        {
            return LocalDateTime.FromDateTime(source);
        }

        /// <summary>
        /// Converts the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="destination">The destination.</param>
        /// <param name="context">The context.</param>
        /// <returns>System.Nullable&lt;LocalDateTime&gt;.</returns>
        public LocalDateTime? Convert(DateTime? source, LocalDateTime? destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return LocalDateTime.FromDateTime(source.Value);
        }
    }
}
