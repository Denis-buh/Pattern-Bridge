



/// <summary>
/// Реализация какой-то платформы.
/// Класс обязательно должен реализовывать общий интерфейс слоя реализации
/// </summary>
class TikTok: IPlatform{
    public string download_video(string linck){
        // Реализация метода. 
        // Именно здесь будет логика, работа с API и прочее...
        // В последующих методах все аналогично
        return TikTokAPI.get_video(linck);
    }

    public string get_description(string linck){
        return TikTokAPI.description_for_video(linck);
    }

    public string get_author(string linck){
        return TikTokAPI.author_for_video(linck);
    }

    public int get_showers(string linck){
        return TikTokAPI.showers(linck);
    }

    public int get_likes(string linck){
        return TikTokAPI.likes(linck);
    }

    public int get_dislikes(string linck){
        return TikTokAPI.dislikes(linck);
    }
}
