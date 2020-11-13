using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Line Renderer Attributes Script
public class LineRendererAttributes : MonoBehaviour
{
		private int numberOfPoints;//the number of points in the line
		private List<Vector3> points;//the points of the line
		public Material material;//the material of the line
		public Color[] colors;//the colors set used to select a random color for the line

		void Start ()
		{
				//Create a new material if the current material is null
				if (material == null) {
						material = new Material (Shader.Find ("Sprites/Default"));
						material.color = Color.red;
				}

				GetComponent<LineRenderer> ().material = material;//set the line material

				//initiate the list of points
				points = new List<Vector3> ();
		}

		//Set a random color
		public void SetRandomColor ()
		{
				if (colors == null) {
						return;
				}

				if (material == null) {
						return;
				}

				material.color = colors [Random.Range (0, colors.Length)];
		}

		//Property for the number of points
		public int NumberOfPoints {
				get{ return this.numberOfPoints;}
				set{ this.numberOfPoints = value;}
		}

		//Property for the points list
		public List<Vector3> Points {
				get{ return this.points;}
				set{ this.points = value;}
		}

}
