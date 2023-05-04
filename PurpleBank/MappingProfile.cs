// MappingProfile.cs
using AutoMapper;
using Microsoft.EntityFrameworkCore;

public class MappingProfile : Profile {
 public MappingProfile() {
  // Add your mapping configurations here@@@
  // For example:
  // CreateMap<SourceClass, DestinationClass>();
 }
}

public static class IMapperExtensions {
 public static TDestination MapToEntity<TSource, TDestination>(this IMapper mapper, TSource source, DbContext dbContext)
     where TDestination : class {
  var destination = mapper.Map<TDestination>(source);
  dbContext.Update(destination);
  return destination;
 }
}
