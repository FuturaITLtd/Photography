using System;
using TechTalk.SpecFlow;
using AlbSvc = Photography.AlbumService;
using DALDomain = Photography.NHibernateDAL.Domain;

namespace SpecFlowTests.Steps
{
    [Binding]
    public class AlbumSteps
    {
        AlbSvc.AlbumService albumService;
        DALDomain.Album dalAlbum;

        [Given(@"a user is creating an album")]
        public void GivenAUserIsCreatingAnAlbum()
        {
            albumService = new AlbSvc.AlbumService();
            dalAlbum = new DALDomain.Album();
            //ScenarioContext.Current.Pending();
        }

        [Given(@"the name is (.*)")]
        public void GivenTheNameIs(string newAlbumName)
        {
            dalAlbum.Name = newAlbumName;
            dalAlbum.CreationDate = DateTime.Now;
            //ScenarioContext.Current.Pending();
        }

        [Given(@"the genre is (.*)")]
        public void GivenTheGenreIs(string newAlbumGenre)
        {
            dalAlbum.Genre = newAlbumGenre;
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"the web request is made")]
        public void WhenTheWebRequestIsMade()
        {
            albumService.CreateAlbum(dalAlbum);
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the album will be sucessfully created")]
        public void ThenTheAlbumWillBeSucessfullyCreated_()
        {
            //albumService.SearchAlbumByName()
            //ScenarioContext.Current.Pending();
        }
    }
}
