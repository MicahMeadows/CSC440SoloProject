I-Logix-RPY-Archive version 8.5.2 Modeler C++ 1159120
{ IProject 
	- _id = GUID 901c2a58-139f-4ca6-9235-431f20ebeb5e;
	- _myState = 8192;
	- _name = "Project";
	- _objectCreation = "9282988302021113137299";
	- _umlDependencyID = "2228";
	- _lastID = 2;
	- _UserColors = { IRPYRawContainer 
		- size = 16;
		- value = 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 16777215; 
	}
	- _defaultSubsystem = { ISubsystemHandle 
		- _m2Class = "ISubsystem";
		- _filename = "Default.sbs";
		- _subsystem = "";
		- _class = "";
		- _name = "Default";
		- _id = GUID e730fca6-c8f7-4a8a-9748-c27412a19783;
	}
	- _component = { IHandle 
		- _m2Class = "IComponent";
		- _filename = "DefaultComponent.cmp";
		- _subsystem = "";
		- _class = "";
		- _name = "DefaultComponent";
		- _id = GUID bf1a9b3a-17a1-4289-a207-17e9a26a4a62;
	}
	- Multiplicities = { IRPYRawContainer 
		- size = 4;
		- value = 
		{ IMultiplicityItem 
			- _name = "1";
			- _count = -1;
		}
		{ IMultiplicityItem 
			- _name = "*";
			- _count = -1;
		}
		{ IMultiplicityItem 
			- _name = "0,1";
			- _count = -1;
		}
		{ IMultiplicityItem 
			- _name = "1..*";
			- _count = -1;
		}
	}
	- Subsystems = { IRPYRawContainer 
		- size = 2;
		- value = 
		{ ISubsystem 
			- fileName = "Default";
			- _id = GUID e730fca6-c8f7-4a8a-9748-c27412a19783;
		}
		{ ISubsystem 
			- fileName = "package_1";
			- _id = GUID 1f658285-04ac-4622-9a6e-dad4bc0260e7;
		}
	}
	- Diagrams = { IRPYRawContainer 
		- size = 1;
		- value = 
		{ IDiagram 
			- _id = GUID 50f44589-2270-4c5e-95a6-02b66600350f;
			- _myState = 8192;
			- _name = "Model1";
			- _objectCreation = "9283408302021113133099";
			- _umlDependencyID = "2029";
			- _lastModifiedTime = "9.8.2021::15:24:49";
			- _graphicChart = { CGIClassChart 
				- _id = GUID 321b338c-72ff-466c-85b1-995b2e0d5080;
				- m_type = 0;
				- m_pModelObject = { IHandle 
					- _m2Class = "IDiagram";
					- _id = GUID 50f44589-2270-4c5e-95a6-02b66600350f;
				}
				- m_pParent = ;
				- m_name = { CGIText 
					- m_str = "";
					- m_style = "Arial" 10 0 0 0 1 ;
					- m_color = { IColor 
						- m_fgColor = 0;
						- m_bgColor = 0;
						- m_bgFlag = 0;
					}
					- m_position = 1 0 0  ;
					- m_nIdent = 0;
					- m_bImplicitSetRectPoints = 0;
					- m_nOrientationCtrlPt = 8;
				}
				- m_drawBehavior = 0;
				- m_bIsPreferencesInitialized = 0;
				- elementList = 1;
				{ CGIClass 
					- _id = GUID 3971f3a5-7801-4c0b-aa0a-31a239db0fa2;
					- m_type = 78;
					- m_pModelObject = { IHandle 
						- _m2Class = "IClass";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "TopLevel";
						- _id = GUID 9e13518b-eb2b-40ca-88f9-432972ccb9fb;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "TopLevel";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 0;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_polygon = 0 ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
					- Attrs = { IRPYRawContainer 
						- size = 0;
					}
					- Operations = { IRPYRawContainer 
						- size = 0;
					}
				}
				
				- m_access = 'Z';
				- m_modified = 'N';
				- m_fileVersion = "";
				- m_nModifyDate = 0;
				- m_nCreateDate = 0;
				- m_creator = "";
				- m_bScaleWithZoom = 1;
				- m_arrowStyle = 'S';
				- m_pRoot = GUID 3971f3a5-7801-4c0b-aa0a-31a239db0fa2;
				- m_currentLeftTop = 0 0 ;
				- m_currentRightBottom = 0 0 ;
			}
			- _defaultSubsystem = { IHandle 
				- _m2Class = "ISubsystem";
				- _filename = "Default.sbs";
				- _subsystem = "";
				- _class = "";
				- _name = "Default";
				- _id = GUID e730fca6-c8f7-4a8a-9748-c27412a19783;
			}
		}
	}
	- Components = { IRPYRawContainer 
		- size = 1;
		- value = 
		{ IComponent 
			- fileName = "DefaultComponent";
			- _id = GUID bf1a9b3a-17a1-4289-a207-17e9a26a4a62;
		}
	}
	- UCDiagrams = { IRPYRawContainer 
		- size = 1;
		- value = 
		{ IUCDiagram 
			- _id = GUID e9d64f50-a7d6-40ef-868e-ebb3774aec5f;
			- _myState = 8192;
			- _properties = { IPropertyContainer 
				- Subjects = { IRPYRawContainer 
					- size = 1;
					- value = 
					{ IPropertySubject 
						- _Name = "Format";
						- Metaclasses = { IRPYRawContainer 
							- size = 5;
							- value = 
							{ IPropertyMetaclass 
								- _Name = "Actor";
								- Properties = { IRPYRawContainer 
									- size = 7;
									- value = 
									{ IProperty 
										- _Name = "DefaultSize";
										- _Value = "0,26,84,168";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Fill.FillColor";
										- _Value = "255,255,255";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Font";
										- _Value = "Arial";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Font.FontColor";
										- _Value = "0,0,128";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Size";
										- _Value = "10";
										- _Type = Int;
									}
									{ IProperty 
										- _Name = "Line.LineColor";
										- _Value = "111,0,107";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Line.LineWidth";
										- _Value = "1";
										- _Type = Int;
									}
								}
							}
							{ IPropertyMetaclass 
								- _Name = "Association";
								- Properties = { IRPYRawContainer 
									- size = 5;
									- value = 
									{ IProperty 
										- _Name = "Font.Font";
										- _Value = "Arial";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Font.FontColor";
										- _Value = "0,0,128";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Size";
										- _Value = "10";
										- _Type = Int;
									}
									{ IProperty 
										- _Name = "Line.LineColor";
										- _Value = "221,0,0";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Line.LineWidth";
										- _Value = "1";
										- _Type = Int;
									}
								}
							}
							{ IPropertyMetaclass 
								- _Name = "Package";
								- Properties = { IRPYRawContainer 
									- size = 7;
									- value = 
									{ IProperty 
										- _Name = "DefaultSize";
										- _Value = "0,0,216,151";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Fill.FillColor";
										- _Value = "255,255,255";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Font";
										- _Value = "Arial";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Font.FontColor";
										- _Value = "0,0,0";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Size";
										- _Value = "10";
										- _Type = Int;
									}
									{ IProperty 
										- _Name = "Line.LineColor";
										- _Value = "221,0,0";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Line.LineWidth";
										- _Value = "1";
										- _Type = Int;
									}
								}
							}
							{ IPropertyMetaclass 
								- _Name = "System_Border";
								- Properties = { IRPYRawContainer 
									- size = 7;
									- value = 
									{ IProperty 
										- _Name = "DefaultSize";
										- _Value = "0,0,228,240";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Fill.FillColor";
										- _Value = "255,255,255";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Font";
										- _Value = "Arial";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Font.FontColor";
										- _Value = "0,0,0";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Size";
										- _Value = "10";
										- _Type = Int;
									}
									{ IProperty 
										- _Name = "Line.LineColor";
										- _Value = "111,0,107";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Line.LineWidth";
										- _Value = "1";
										- _Type = Int;
									}
								}
							}
							{ IPropertyMetaclass 
								- _Name = "UseCase";
								- Properties = { IRPYRawContainer 
									- size = 7;
									- value = 
									{ IProperty 
										- _Name = "DefaultSize";
										- _Value = "0,21,129,92";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Fill.FillColor";
										- _Value = "255,255,255";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Font";
										- _Value = "Arial";
										- _Type = String;
									}
									{ IProperty 
										- _Name = "Font.FontColor";
										- _Value = "0,0,0";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Font.Size";
										- _Value = "10";
										- _Type = Int;
									}
									{ IProperty 
										- _Name = "Line.LineColor";
										- _Value = "111,0,107";
										- _Type = Color;
									}
									{ IProperty 
										- _Name = "Line.LineWidth";
										- _Value = "1";
										- _Type = Int;
									}
								}
							}
						}
					}
				}
			}
			- _name = "MainSystemDiagram";
			- _objectCreation = "9283428302021113132899";
			- _umlDependencyID = "3219";
			- _lastModifiedTime = "9.8.2021::15:30:2";
			- _graphicChart = { CGIClassChart 
				- _id = GUID 0fc698a1-551c-4ec3-91b6-c7ff38e186ae;
				- m_type = 0;
				- m_pModelObject = { IHandle 
					- _m2Class = "IUCDiagram";
					- _id = GUID e9d64f50-a7d6-40ef-868e-ebb3774aec5f;
				}
				- m_pParent = ;
				- m_name = { CGIText 
					- m_str = "";
					- m_style = "Arial" 10 0 0 0 1 ;
					- m_color = { IColor 
						- m_fgColor = 0;
						- m_bgColor = 0;
						- m_bgFlag = 0;
					}
					- m_position = 1 0 0  ;
					- m_nIdent = 0;
					- m_bImplicitSetRectPoints = 0;
					- m_nOrientationCtrlPt = 8;
				}
				- m_drawBehavior = 0;
				- m_bIsPreferencesInitialized = 0;
				- elementList = 13;
				{ CGIClass 
					- _id = GUID c421c226-27bd-4e83-948a-6aaa90090c4a;
					- m_type = 78;
					- m_pModelObject = { IHandle 
						- _m2Class = "IClass";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "TopLevel";
						- _id = GUID 9e13518b-eb2b-40ca-88f9-432972ccb9fb;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "TopLevel";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 0;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_polygon = 0 ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
					- Attrs = { IRPYRawContainer 
						- size = 0;
					}
					- Operations = { IRPYRawContainer 
						- size = 0;
					}
				}
				{ CGIBasicClass 
					- _id = GUID a80e6107-abb7-4353-b319-d71d01feaf0f;
					- m_type = 124;
					- m_pModelObject = { IHandle 
						- _m2Class = "IActor";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "User";
						- _id = GUID 81cc6433-4f67-4017-b802-a9b3d58c36f9;
					}
					- m_pParent = GUID c421c226-27bd-4e83-948a-6aaa90090c4a;
					- m_name = { CGIText 
						- m_str = "User";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 2056;
					- m_transform = 0.106285 0 0 0.157941 91.7486 268.515 ;
					- m_bIsPreferencesInitialized = 1;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_polygon = 4 40 250  40 1396  1122 1396  1122 250  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
				}
				{ CGIBox 
					- _id = GUID 8ab37d41-24a2-4c84-bbf2-da07d8aa5256;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "FitBoxToItsTextuals";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 123;
					- m_pModelObject = { IHandle 
						- _m2Class = "";
					}
					- m_pParent = GUID c421c226-27bd-4e83-948a-6aaa90090c4a;
					- m_name = { CGIText 
						- m_str = "Registrar Course Record Manager";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_drawBehavior = 4096;
					- m_transform = 0.290717 0 0 0.447581 319 132 ;
					- m_bIsPreferencesInitialized = 1;
					- m_polygon = 4 0 0  0 1240  1228 1240  1228 0  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
				}
				{ CGIBasicClass 
					- _id = GUID 47f30529-42c4-4bbf-959d-65b3cde13578;
					- m_type = 125;
					- m_pModelObject = { IHandle 
						- _m2Class = "IUseCase";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "Import course records from excel sheet";
						- _id = GUID 8b9784e1-e384-4551-b6c8-ae70ffc18345;
					}
					- m_pParent = GUID 8ab37d41-24a2-4c84-bbf2-da07d8aa5256;
					- m_name = { CGIText 
						- m_str = "Import course records from excel sheet";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 2056;
					- m_transform = 0.338449 0 0 0.154373 417.658 172.19 ;
					- m_bIsPreferencesInitialized = 1;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_polygon = 4 -2 -1  -2 1070  1127 1070  1127 -1  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
				}
				{ CGIBasicClass 
					- _id = GUID 1990c62b-7e87-4f37-a8cc-bb65225775cd;
					- m_type = 125;
					- m_pModelObject = { IHandle 
						- _m2Class = "IUseCase";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "Add individual records";
						- _id = GUID b6c2cfd5-3d4e-4988-8af6-50ea63bff0ab;
					}
					- m_pParent = GUID 8ab37d41-24a2-4c84-bbf2-da07d8aa5256;
					- m_name = { CGIText 
						- m_str = "Add individual records";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 2056;
					- m_transform = 0.335866 0 0 0.150201 426.926 373.267 ;
					- m_bIsPreferencesInitialized = 1;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_polygon = 4 -2 -1  -2 1070  1127 1070  1127 -1  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
				}
				{ CGIBasicClass 
					- _id = GUID 09a7c85e-da49-48f1-b856-a5dff7491d81;
					- m_type = 125;
					- m_pModelObject = { IHandle 
						- _m2Class = "IUseCase";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "Edit individual records";
						- _id = GUID e772bf95-c176-4c22-8d80-049b85f62b05;
					}
					- m_pParent = GUID 8ab37d41-24a2-4c84-bbf2-da07d8aa5256;
					- m_name = { CGIText 
						- m_str = "Edit individual records";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 2056;
					- m_transform = 0.340858 0 0 0.143942 444.149 572.108 ;
					- m_bIsPreferencesInitialized = 1;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_polygon = 4 -2 -1  -2 1070  1127 1070  1127 -1  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
				}
				{ CGIBasicClass 
					- _id = GUID d9523778-9f5d-44c8-b0ba-4c9a0ade9e6c;
					- m_type = 125;
					- m_pModelObject = { IHandle 
						- _m2Class = "IUseCase";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "Delete individual records";
						- _id = GUID 12e9e7b0-06ed-400e-897a-69b4b4d3ac1a;
					}
					- m_pParent = GUID 8ab37d41-24a2-4c84-bbf2-da07d8aa5256;
					- m_name = { CGIText 
						- m_str = "Delete individual records";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 2056;
					- m_transform = 0.347848 0 0 0.141856 444.451 757.547 ;
					- m_bIsPreferencesInitialized = 1;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_polygon = 4 -2 -1  -2 1070  1127 1070  1127 -1  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
				}
				{ CGIBasicClass 
					- _id = GUID 74dbd6aa-a7e8-4455-8e99-5594e8aea1f9;
					- m_type = 125;
					- m_pModelObject = { IHandle 
						- _m2Class = "IUseCase";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "";
						- _name = "Print Reports";
						- _id = GUID 4bbf08dd-4337-4567-bb88-93fea0076b61;
					}
					- m_pParent = GUID 8ab37d41-24a2-4c84-bbf2-da07d8aa5256;
					- m_name = { CGIText 
						- m_str = "Print Reports";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 5;
					}
					- m_drawBehavior = 2056;
					- m_transform = 0.34585 0 0 0.137684 458.204 938.516 ;
					- m_bIsPreferencesInitialized = 1;
					- m_AdditionalLabel = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 1;
					}
					- m_polygon = 4 -2 -1  -2 1070  1127 1070  1127 -1  ;
					- m_nNameFormat = 0;
					- m_nIsNameFormat = 0;
				}
				{ CGIAssociationEnd 
					- _id = GUID eedb1d36-2c24-41ad-9587-2115c00490bc;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "ShowLabels";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 94;
					- m_pModelObject = { IHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "User";
						- _name = "itsImport course records from excel sheet";
						- _id = GUID 92c34cb6-e1c9-48a6-a114-6741e562db28;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 1;
					- m_pSource = GUID a80e6107-abb7-4353-b319-d71d01feaf0f;
					- m_sourceType = 'F';
					- m_pTarget = GUID 47f30529-42c4-4bbf-959d-65b3cde13578;
					- m_targetType = 'T';
					- m_direction = ' ';
					- m_rpn = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 7;
					}
					- m_anglePoint1 = 0 0 ;
					- m_anglePoint2 = 0 0 ;
					- m_line_style = 0;
					- m_SourcePort = 1103 554 ;
					- m_TargetPort = 24 520 ;
					- m_pInverseModelObject = { IAssociationEndHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "Import course records from excel sheet";
						- _name = "itsUser";
						- _id = GUID 64889f12-0731-40c6-9e2b-48a5adb19159;
					}
					- m_pInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_pInverseInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_bShowSourceMultiplicity = 0;
					- m_bShowSourceRole = 0;
					- m_bShowTargetMultiplicity = 0;
					- m_bShowTargetRole = 0;
					- m_bShowLinkName = 1;
					- m_bShowSpecificType = 0;
					- m_bInstance = 0;
					- m_bShowQualifier1 = 0;
					- m_bShowQualifier2 = 0;
					- m_sourceRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 2;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 3;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 4;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 5;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 6;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_targetQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 7;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_specificType = symmetric_type;
				}
				{ CGIAssociationEnd 
					- _id = GUID 1a632ca4-b82d-413f-a5b3-c9d41ca209c5;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "ShowLabels";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 94;
					- m_pModelObject = { IHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "User";
						- _name = "itsAdd individual records";
						- _id = GUID 6afbe7ff-76da-4b5b-9bd6-4c0c3fd322ba;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 1;
					- m_pSource = GUID a80e6107-abb7-4353-b319-d71d01feaf0f;
					- m_sourceType = 'F';
					- m_pTarget = GUID 1990c62b-7e87-4f37-a8cc-bb65225775cd;
					- m_targetType = 'T';
					- m_direction = ' ';
					- m_rpn = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 7;
					}
					- m_anglePoint1 = 0 0 ;
					- m_anglePoint2 = 0 0 ;
					- m_line_style = 0;
					- m_SourcePort = 661 750 ;
					- m_TargetPort = 41 520 ;
					- m_pInverseModelObject = { IAssociationEndHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "Add individual records";
						- _name = "itsUser";
						- _id = GUID 86991fd9-51a3-43dc-8793-29023b801bdd;
					}
					- m_pInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_pInverseInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_bShowSourceMultiplicity = 0;
					- m_bShowSourceRole = 0;
					- m_bShowTargetMultiplicity = 0;
					- m_bShowTargetRole = 0;
					- m_bShowLinkName = 1;
					- m_bShowSpecificType = 0;
					- m_bInstance = 0;
					- m_bShowQualifier1 = 0;
					- m_bShowQualifier2 = 0;
					- m_sourceRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 2;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 3;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 4;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 5;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 6;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_targetQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 7;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_specificType = symmetric_type;
				}
				{ CGIAssociationEnd 
					- _id = GUID 6ba1c423-8747-45c2-9202-c90c370364fa;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "ShowLabels";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 94;
					- m_pModelObject = { IHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "User";
						- _name = "itsEdit individual records";
						- _id = GUID f4404068-fcd3-44fb-80d7-b8544c10b630;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 1;
					- m_pSource = GUID a80e6107-abb7-4353-b319-d71d01feaf0f;
					- m_sourceType = 'F';
					- m_pTarget = GUID 09a7c85e-da49-48f1-b856-a5dff7491d81;
					- m_targetType = 'T';
					- m_direction = ' ';
					- m_rpn = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 7;
					}
					- m_anglePoint1 = 0 0 ;
					- m_anglePoint2 = 0 0 ;
					- m_line_style = 0;
					- m_SourcePort = 717 744 ;
					- m_TargetPort = 14 511 ;
					- m_pInverseModelObject = { IAssociationEndHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "Edit individual records";
						- _name = "itsUser";
						- _id = GUID 4a948ba2-724a-443c-aa8e-66a30b60323d;
					}
					- m_pInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_pInverseInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_bShowSourceMultiplicity = 0;
					- m_bShowSourceRole = 0;
					- m_bShowTargetMultiplicity = 0;
					- m_bShowTargetRole = 0;
					- m_bShowLinkName = 1;
					- m_bShowSpecificType = 0;
					- m_bInstance = 0;
					- m_bShowQualifier1 = 0;
					- m_bShowQualifier2 = 0;
					- m_sourceRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 2;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 3;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 4;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 5;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 6;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_targetQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 7;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_specificType = symmetric_type;
				}
				{ CGIAssociationEnd 
					- _id = GUID 746276f3-badf-4221-a4c8-08c01577df3e;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "ShowLabels";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 94;
					- m_pModelObject = { IHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "User";
						- _name = "itsDelete individual records";
						- _id = GUID 438d338d-ce6a-4d75-a345-c5fe6a7f81be;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 1;
					- m_pSource = GUID a80e6107-abb7-4353-b319-d71d01feaf0f;
					- m_sourceType = 'F';
					- m_pTarget = GUID d9523778-9f5d-44c8-b0ba-4c9a0ade9e6c;
					- m_targetType = 'T';
					- m_direction = ' ';
					- m_rpn = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 7;
					}
					- m_anglePoint1 = 0 0 ;
					- m_anglePoint2 = 0 0 ;
					- m_line_style = 0;
					- m_SourcePort = 708 750 ;
					- m_TargetPort = 14 535 ;
					- m_pInverseModelObject = { IAssociationEndHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "Delete individual records";
						- _name = "itsUser";
						- _id = GUID ce774a81-64fe-4ab1-964b-507e0562ac85;
					}
					- m_pInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_pInverseInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_bShowSourceMultiplicity = 0;
					- m_bShowSourceRole = 0;
					- m_bShowTargetMultiplicity = 0;
					- m_bShowTargetRole = 0;
					- m_bShowLinkName = 1;
					- m_bShowSpecificType = 0;
					- m_bInstance = 0;
					- m_bShowQualifier1 = 0;
					- m_bShowQualifier2 = 0;
					- m_sourceRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 2;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 3;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 4;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 5;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 6;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_targetQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 7;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_specificType = symmetric_type;
				}
				{ CGIAssociationEnd 
					- _id = GUID 3bc563d5-f0d0-413f-9225-55a3b7f1f132;
					- _properties = { IPropertyContainer 
						- Subjects = { IRPYRawContainer 
							- size = 1;
							- value = 
							{ IPropertySubject 
								- _Name = "General";
								- Metaclasses = { IRPYRawContainer 
									- size = 1;
									- value = 
									{ IPropertyMetaclass 
										- _Name = "Graphics";
										- Properties = { IRPYRawContainer 
											- size = 1;
											- value = 
											{ IProperty 
												- _Name = "ShowLabels";
												- _Value = "False";
												- _Type = Bool;
											}
										}
									}
								}
							}
						}
					}
					- m_type = 94;
					- m_pModelObject = { IHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "User";
						- _name = "itsPrint Reports";
						- _id = GUID 751666f8-67c2-4009-894f-02968f50e686;
					}
					- m_pParent = ;
					- m_name = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_drawBehavior = 0;
					- m_bIsPreferencesInitialized = 1;
					- m_pSource = GUID a80e6107-abb7-4353-b319-d71d01feaf0f;
					- m_sourceType = 'F';
					- m_pTarget = GUID 74dbd6aa-a7e8-4455-8e99-5594e8aea1f9;
					- m_targetType = 'T';
					- m_direction = ' ';
					- m_rpn = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 0;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 7;
					}
					- m_anglePoint1 = 0 0 ;
					- m_anglePoint2 = 0 0 ;
					- m_line_style = 0;
					- m_SourcePort = 924 1377 ;
					- m_TargetPort = 36 567 ;
					- m_pInverseModelObject = { IAssociationEndHandle 
						- _m2Class = "IAssociationEnd";
						- _filename = "Default.sbs";
						- _subsystem = "Default";
						- _class = "Print Reports";
						- _name = "itsUser";
						- _id = GUID ee63f17c-df02-4e5e-9c89-a7555d820286;
					}
					- m_pInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_pInverseInstance = { IObjectLinkHandle 
						- _m2Class = "";
					}
					- m_bShowSourceMultiplicity = 0;
					- m_bShowSourceRole = 0;
					- m_bShowTargetMultiplicity = 0;
					- m_bShowTargetRole = 0;
					- m_bShowLinkName = 1;
					- m_bShowSpecificType = 0;
					- m_bInstance = 0;
					- m_bShowQualifier1 = 0;
					- m_bShowQualifier2 = 0;
					- m_sourceRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 2;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetRole = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 3;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 4;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_targetMultiplicity = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 5;
						- m_bImplicitSetRectPoints = 0;
					}
					- m_sourceQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 6;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_targetQualifier = { CGIText 
						- m_str = "";
						- m_style = "Arial" 10 0 0 0 1 ;
						- m_color = { IColor 
							- m_fgColor = 0;
							- m_bgColor = 0;
							- m_bgFlag = 0;
						}
						- m_position = 1 0 0  ;
						- m_nIdent = 7;
						- m_bImplicitSetRectPoints = 0;
						- m_nOrientationCtrlPt = 8;
					}
					- m_specificType = symmetric_type;
				}
				
				- m_access = 'Z';
				- m_modified = 'N';
				- m_fileVersion = "";
				- m_nModifyDate = 0;
				- m_nCreateDate = 0;
				- m_creator = "";
				- m_bScaleWithZoom = 1;
				- m_arrowStyle = 'S';
				- m_pRoot = GUID c421c226-27bd-4e83-948a-6aaa90090c4a;
				- m_currentLeftTop = 0 0 ;
				- m_currentRightBottom = 0 0 ;
			}
			- _defaultSubsystem = { IHandle 
				- _m2Class = "ISubsystem";
				- _filename = "Default.sbs";
				- _subsystem = "";
				- _class = "";
				- _name = "Default";
				- _id = GUID e730fca6-c8f7-4a8a-9748-c27412a19783;
			}
		}
	}
}

