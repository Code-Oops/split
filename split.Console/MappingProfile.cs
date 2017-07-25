using AutoMapper.Configuration;

namespace split.Console
{
    public class MappingProfile : MapperConfigurationExpression
    {
        public MappingProfile()
        {
            // Register mappings between persistence models and view models
            //CreateMap<Contact, ContactViewModel>().ReverseMap();
        }

        /*[Fact]
        public void MappingProfile_VerifyMappings()
        {
            var mappingProfile = new MappingProfile();

            var config = new MapperConfiguration(mappingProfile);
            var mapper = new Mapper(config);

            (mapper as IMapper).ConfigurationProvider.AssertConfigurationIsValid();
        }*/
    }
}
