using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// Implement your game events in this script
public class Events : MonoBehaviour
{
		private WritingHandler writingHandler;

		void Start ()
		{
				//Setting up the writingHandler reference
				GameObject letters = HierrachyManager.FindActiveGameObjectWithName ("Letters");
				if (letters != null)
						writingHandler = letters.GetComponent<WritingHandler> ();
		}

		//Load the next letter
		public void LoadTheNextLetter (object ob)
		{
				if (writingHandler == null) {
						return;
				}
				writingHandler.LoadNextLetter ();
		}

		//Load the previous letter
		public void LoadThePreviousLetter (object ob)
		{
				if (writingHandler == null) {
						return;
				}
				writingHandler.LoadPreviousLetter ();

		}

		//Load the current letter
		public void LoadLetter (Object ob)
		{
				if (ob == null) {
						return;
				}
				WritingHandler.currentLetterIndex = int.Parse (ob.name.Split ('-') [1]);
				SceneManager.LoadScene("AlphabetWriting");
		}
	
		//Erase the current letter
		public void EraseLetter (Object ob)
		{
				if (writingHandler == null) {
						return;
				}
				writingHandler.RefreshProcess ();

		}

	//Load alphabet menu
	public void LoadAlphabetMenu(Object ob){
		SceneManager.LoadScene("AlphabetMenu");
	}

		//Load shapes menu
		public void LoadShapesMenu(Object ob){
			SceneManager.LoadScene("ShapesMenu");
		}
}