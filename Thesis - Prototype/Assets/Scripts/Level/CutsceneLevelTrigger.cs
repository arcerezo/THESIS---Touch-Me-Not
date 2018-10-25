using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneLevelTrigger : MonoBehaviour {
	
	public string sceneIndex;
	void Start ()
	{
		sceneIndex = SceneManager.GetActiveScene().name;
		
		Debug.Log(sceneIndex);
	}
	public void LoadNextScene ()
	{

		if  (sceneIndex == "CH_1") {
			SceneManager.LoadScene("Chapter1");
			sceneIndex = "Chapter1";
		}
			else if (sceneIndex == "Chapter1")
			{
				SceneManager.LoadScene("Chapter1_1");
				sceneIndex = "Chapter1_1";
			}
				else if (sceneIndex == "Chapter1_1")
				{
					SceneManager.LoadScene("Chapter1_2");
					sceneIndex = "Chapter1_2";
				}
					else if (sceneIndex == "Chapter1_2")
					{
						SceneManager.LoadScene("Chapter2");
						sceneIndex = "Chapter2";
					}
						else if (sceneIndex == "Chapter2")
						{
							SceneManager.LoadScene("Chapter2_1");
							sceneIndex = "Chapter2_1";
						}
							else if(sceneIndex == "Chapter2_1")
							{
								SceneManager.LoadScene("Chapter2_2");
								sceneIndex = "Chapter2_2";
							}
								else if(sceneIndex == "Chapter2_2")
								{
									SceneManager.LoadScene("Chapter2_3");
									sceneIndex = "Chapter2_3";
								}
									else if(sceneIndex == "Chapter2_3")
									{
										SceneManager.LoadScene("Chapter2_4");
										sceneIndex = "Chapter2_4";
									}
										else if(sceneIndex == "Chapter2_4")
										{
											SceneManager.LoadScene("Chapter3");
											sceneIndex = "Chapter3";
										}
											else if (sceneIndex == "Chapter3")
											{
												SceneManager.LoadScene("Chapter3_1");
												sceneIndex = "Chapter3_1";
											}
												else if(sceneIndex == "Chapter3_1")
												{
													SceneManager.LoadScene("Chapter3_2");
													sceneIndex = "Chapter3_2";
												}
													else if(sceneIndex == "Chapter3_2")
													{
														SceneManager.LoadScene("Chapter3_3");
														sceneIndex = "Chapter3_3";
													}
														else if(sceneIndex == "Chapter3_3")
														{
															SceneManager.LoadScene("Chapter3_4");
															sceneIndex = "Chapter3_4";
														}
															else if(sceneIndex == "Chapter3_5")
															{
																SceneManager.LoadScene("Chapter4");
																sceneIndex = "Chapter4";
															}
																else if(sceneIndex == "Chapter4")
																{
																	SceneManager.LoadScene("Chapter4_1");
																	sceneIndex = "Chapter4_1";
																}
	}
}
