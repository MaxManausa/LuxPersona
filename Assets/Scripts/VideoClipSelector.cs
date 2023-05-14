using UnityEngine;
using UnityEngine.Video;

public class VideoClipSelector : MonoBehaviour
{
    [SerializeField] VideoClip[] videoClips;
    [SerializeField]  ChangeTranscripttext transcriptText;
    [SerializeField]  VideoPlayer videoPlayer;
    private int currentClipIndex = 0;
    

    public void RightArrow()
    {
        currentClipIndex = (currentClipIndex + 1) % videoClips.Length;
        videoPlayer.clip = videoClips[currentClipIndex];
        videoPlayer.Play();

        // Call the appropriate transcript text method based on the selected clip index
        switch (currentClipIndex)
        {
            case 0:
                transcriptText.Transcript1();
                break;
            case 1:
                transcriptText.Transcript2();
                break;
            case 2:
                transcriptText.Transcript3();
                break;
            case 3:
                transcriptText.Transcript4();
                break;
            case 4:
                transcriptText.Transcript5();
                break;
            case 5:
                transcriptText.Transcript6();
                break;
            case 6:
                transcriptText.Transcript7();
                break;
            case 7:
                transcriptText.Transcript8();
                break;
            case 8:
                transcriptText.Transcript9();
                break;
            case 9:
                transcriptText.Transcript10();
                break;
            case 10:
                transcriptText.Transcript11();
                break;
            case 11:
                transcriptText.Transcript12();
                break;

            // and so on for the remaining clips...
        }
    }

    public void LeftArrow()
    {
        currentClipIndex = (currentClipIndex - 1 + videoClips.Length) % videoClips.Length; 
        videoPlayer.clip = videoClips[currentClipIndex]; 
        videoPlayer.Play();

        // Call the appropriate transcript text method based on the selected clip index
            switch (currentClipIndex)
            {
                case 0:
                    transcriptText.Transcript1();
                    break;
                case 1:
                    transcriptText.Transcript2();
                    break;
                case 2:
                    transcriptText.Transcript3();
                    break;
                case 3:
                    transcriptText.Transcript4();
                    break;
                case 4:
                    transcriptText.Transcript5();
                    break;
                case 5:
                    transcriptText.Transcript6();
                    break;
                case 6:
                    transcriptText.Transcript7();
                    break;
                case 7:
                    transcriptText.Transcript8();
                    break;
                case 8:
                    transcriptText.Transcript9();
                    break;
                case 9:
                    transcriptText.Transcript10();
                    break;
                case 10:
                    transcriptText.Transcript11();
                    break;
                case 11:
                    transcriptText.Transcript12();
                    break;

                // and so on for the remaining clips...
            }
        }
}