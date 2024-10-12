using CatchUpPlatform.API.News.Shared.Domain.Model.Commands;

namespace CatchUpPlatform.API.News.Shared.Domain.Model.Aggregates;
// FavoriteSource Aggregate
// <summary>
// Esta clase es la que se encarga de guardar las fuentes favoritas de los usuarios
// </summary>
public class FavoriteSource
{
    public int Id { get; private set; }
    
    public string NewsApiKey { get;private set; }
    
    public string SourceId { get; private set; }

    protected FavoriteSource()
    {
        this.NewsApiKey = string.Empty;
        this.SourceId = string.Empty;
    }
    //<summary>
    //Constructor for the FavoriteSource Aggregate
    //</summary>
    //<remarks>
    //This constructor is used to create a FavoriteSource object
    //</remarks>
    public FavoriteSource(CreateFavoriteSourceCommand command)
    {
        this.NewsApiKey=command.NewsApiKey;
        this.SourceId=command.SourceId;
    }
    
}