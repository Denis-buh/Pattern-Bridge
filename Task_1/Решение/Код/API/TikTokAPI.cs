



/// <summary>Условная API для работы с TikTok</summary>
static class TikTokAPI{
    public static string get_video(string linck){
        return "video was downloaded";
    }

    public static string description_for_video(string linck){
        return "description of the video";
    }

    public static string author_for_video(string linck){
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