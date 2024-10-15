using CatchUpPlatform.API.News.Domain.Model.Commands;
namespace CatchUpPlatform.API.News.Domain.Model.Aggregates;
/// <summary>
/// This class represents the FavoriteSource aggregate. It is used to store the favorite sources of a user
/// </summary>
/// 
public class FavoriteSource
{
    public int Id { get; private set; }
    
    public string NewsApiKey { get; private set; }
    
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