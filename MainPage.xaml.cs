using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

/*using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;*/

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Mood_Music
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

       /* private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SearchForSongs("Happy music");
            }
            catch (AggregateException ex)
            {
                foreach (var exs in ex.InnerExceptions)
                {
                    Debug.WriteLine("Error: " + exs.Message);
                }
            }
        }

        private void SearchForSongs(string mood)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBupBiyT9BAdC_txINLPjJn9jBH8Iujb94",
                ApplicationName = "bart-189220"
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            //searchListRequest.VideoCategoryId = "10";
            searchListRequest.Q = mood;
            searchListRequest.MaxResults = 50;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = searchListRequest.Execute();


            List<string> videos = new List<string>();
            List<string> channels = new List<string>();
            List<string> playlists = new List<string>();

            // Add each result to the appropriate list, and then display the lists of
            // matching videos, channels, and playlists.

            int musicList = searchListResponse.Items.Count;
            Random rnd = new Random();
            int itemToPlay = rnd.Next(musicList);
            SearchResult myVideo = searchListResponse.Items[itemToPlay];
            string videoID = "";
            switch (myVideo.Id.Kind)
            {
                case "youtube#video":
                    videoID = myVideo.Id.VideoId;
                    break;

                case "youtube#channel":
                    videoID = myVideo.Id.ChannelId;
                    break;

                case "youtube#playlist":
                    videoID = myVideo.Id.PlaylistId;
                    break;
            }

            Debug.WriteLine(string.Format("{0} : {1}", myVideo.Snippet.Title, videoID));
            webview.Source = new Uri(string.Format("https://www.youtube.com/embed/{0}?rel=0&autoplay=1;html5=True;", videoID));
            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                        break;

                    case "youtube#channel":
                        channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                        break;

                    case "youtube#playlist":
                        playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                        break;
                }
            }
            //Debug.WriteLine(String.Format("Videos:\n{0}\n", string.Join("\n", videos)));
            //Debug.WriteLine(String.Format("Channels:\n{0}\n", string.Join("\n", channels)));
            //Debug.WriteLine(String.Format("Playlists:\n{0}\n", string.Join("\n", playlists)));
        }*/

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
                MoodList.Items.Add("Happy");
                MoodList.Items.Add("Sad");
                MoodList.Items.Add("Tired");
                MoodList.Items.Add("In Love");
                MoodList.Items.Add("Studious");
                MoodList.Items.Add("Silly");
                MoodList.Items.Add("Festive");
        }



       /* private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine(e.AddedItems[0]);
            string SearchTerms = string.Format("Songs with {0} lyrics", e.AddedItems[0]);
            SearchForSongs(SearchTerms);
        }*/
    }
}
