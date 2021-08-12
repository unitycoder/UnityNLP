using UnityEngine;
using VoxellNLP.Tools.SentenceDetect;
using Voxell.Inspector;
using Voxell;


public class NLPSentenceSplitter : MonoBehaviour
{
  [StreamingAssetFilePath]
  public string splitterModel;
  [TextArea(1, 5)] public string paragraph;
  [TextArea(1, 3)] public string[] sentences;

  private EnglishMaximumEntropySentenceDetector sentenceDetector;

  [Button]
  void SplitSentence()
  {
    sentenceDetector = new EnglishMaximumEntropySentenceDetector(FileUtil.GetStreamingAssetFilePath(splitterModel));
    sentences = sentenceDetector.SentenceDetect(paragraph);
  }
}