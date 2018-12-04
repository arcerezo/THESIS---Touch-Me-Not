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
						SceneManager.LoadScene("Chapter1_Quiz");
						sceneIndex = "Chapter1_Quiz";
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
											SceneManager.LoadScene("Chapter2_Quiz");
											sceneIndex = "Chapter2_Quiz";
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
																SceneManager.LoadScene("Chapter3_Quiz");
																sceneIndex = "Chapter3_Quiz";
															}
																else if(sceneIndex == "Chapter4")
																{
																	SceneManager.LoadScene("Chapter4_1");
																	sceneIndex = "Chapter4_1";
																}
																	else if(sceneIndex == "Chapter4_1")
																	{
																		SceneManager.LoadScene("Chapter4_2");
																		sceneIndex = "Chapter4_2";
																	}
																		else if(sceneIndex == "Chapter4_3")
																		{
																			SceneManager.LoadScene("Chapter4_Quiz");
																			sceneIndex = "Chapter4_Quiz";
																		}
																			else if(sceneIndex == "Chapter5")
																			{
																				SceneManager.LoadScene("Chapter5_1");
																				sceneIndex = "Chapter5_1";
																			}
																				else if(sceneIndex == "Chapter5_1")
																				{
																					SceneManager.LoadScene("Chapter5_2");
																					sceneIndex = "Chapter5_2";
																				}
																					else if(sceneIndex == "Chapter5_2")
																					{
																						SceneManager.LoadScene("End Credits");
																						sceneIndex = "End Credits";
																					}
																						else if(sceneIndex == "End Credits")
																						{
																							SceneManager.LoadScene("Main Menu");
																							sceneIndex = "Main Menu";
																						}
	}
}
