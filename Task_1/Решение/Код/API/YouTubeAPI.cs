



/// <summary>Условная API для работы с YouTube</summary>
static class YouTubeAPI{
    public static string download(string linck){
        return "video was downloaded";
    }

    public static string descript(string linck){
        return "description of the video";
    }

    public static string author(string linck){
        return "author";
    }

    public static int showers(string linck){
        return $"views to video by link {linck}".Length; 
    }

    public static int likes(string linck){
        return $"likes to video by link {linck}".Length;
    }

    public static int dislikes(string linck){
        return $"dislikes to video by link {linck}".Length; 
    }
}