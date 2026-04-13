FUNCTION: Libraries::CamerasManager::onInit
ENTRY: 18000d080
REASONS: string:loadCamera


/* public: virtual int __cdecl Libraries::CamerasManager::onInit(void) __ptr64 */

int __thiscall Libraries::CamerasManager::onInit(CamerasManager *this)

{
  char cVar1;
  longlong *plVar2;
  longlong *plVar3;
  int iVar4;
  longlong *plVar5;
  Cameras *pCVar6;
  longlong lVar7;
  longlong local_48;
  undefined8 uStack_40;
  undefined8 local_38;
  undefined8 local_30;
  Cameras *local_28;
  
                    /* 0xd080  833  ?onInit@CamerasManager@Libraries@@UEAAHXZ */
  plVar5 = FUN_1800014c0();
  local_48 = 0;
  uStack_40 = 0;
  local_38 = 0;
  local_30 = 0;
  FUN_18000c1d0(&local_48,"loadCamera: initializing camera ->onInit() - Loading Camera factory...",
                0x46);
  FUN_180084c00(plVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_48,0,'\x01');
  plVar5 = FUN_1800014c0();
  local_48 = 0;
  uStack_40 = 0;
  local_38 = 0;
  local_30 = 0;
  FUN_18000c1d0(&local_48,"Load Camera factory ... ",0x18);
  FUN_180084c00(plVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_48,0,'\x01');
  if (*(int *)(this + 0xe0) == 2) {
    plVar5 = FUN_1800014c0();
    local_48 = 0;
    uStack_40 = 0;
    local_38 = 0;
    local_30 = 0;
    FUN_18000c1d0(&local_48,
                  "CamerasManager::onInit(): New Libraries::HikrobotCircularBuffer::Cameras() :: HIKROBOT_MV_CA003_21UC..."
                  ,0x67);
    FUN_180084c00(plVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_48,1,'\x01');
    pCVar6 = (Cameras *)FUN_1801327e0(0xf0);
    local_28 = pCVar6;
    memset(pCVar6,0,0xf0);
    lVar7 = HikrobotCircularBuffer::Cameras::Cameras
                      (pCVar6,(unique_ptr<class_std::vector<class_Hikrobot::CameraPtr,class_std::allocator<class_Hikrobot::CameraPtr>_>,struct_std::default_delete<class_std::vector<class_Hikrobot::CameraPtr,class_std::allocator<class_Hikrobot::CameraPtr>_>_>_>
                               *)(this + 0xd8));
    local_48 = 0;
    uStack_40 = 0;
    local_38 = 0;
    local_30 = 0;
    FUN_18000c1d0(&local_48,"HIKROBOT_MV_CA003_21UC",0x16);
    plVar5 = FUN_18000dce0((longlong *)(this + 0xe8),&local_48);
    *plVar5 = lVar7;
  }
  else {
    if (*(int *)(this + 0xe0) != 3) goto LAB_18000d291;
    plVar5 = FUN_1800014c0();
    local_48 = 0;
    uStack_40 = 0;
    local_38 = 0;
    local_30 = 0;
    FUN_18000c1d0(&local_48,
                  "CamerasManager::onInit(): New Libraries::HikrobotCircularBuffer::Cameras() :: HIKROBOT_MV_CA004_10UC..."
                  ,0x67);
    FUN_180084c00(plVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_48,1,'\x01');
    pCVar6 = (Cameras *)FUN_1801327e0(0xf0);
    local_28 = pCVar6;
    memset(pCVar6,0,0xf0);
    lVar7 = HikrobotCircularBuffer::Cameras::Cameras
                      (pCVar6,(unique_ptr<class_std::vector<class_Hikrobot::CameraPtr,class_std::allocator<class_Hikrobot::CameraPtr>_>,struct_std::default_delete<class_std::vector<class_Hikrobot::CameraPtr,class_std::allocator<class_Hikrobot::CameraPtr>_>_>_>
                               *)(this + 0xd8));
    local_48 = 0;
    uStack_40 = 0;
    local_38 = 0;
    local_30 = 0;
    FUN_18000c1d0(&local_48,"HIKROBOT_MV_CA004_10UC",0x16);
    plVar5 = FUN_18000dce0((longlong *)(this + 0xe8),&local_48);
    *plVar5 = lVar7;
  }
  FUN_18000c8d0(&local_48);
LAB_18000d291:
  plVar5 = (longlong *)**(longlong **)(this + 0xe8);
  cVar1 = *(char *)((longlong)plVar5 + 0x19);
  while( true ) {
    if (cVar1 != '\0') {
      return 0;
    }
    iVar4 = CamerasCore::init((CamerasCore *)plVar5[8]);
    if (iVar4 != 0) break;
    plVar2 = (longlong *)plVar5[2];
    if (*(char *)((longlong)plVar2 + 0x19) == '\0') {
      cVar1 = *(char *)(*plVar2 + 0x19);
      plVar5 = plVar2;
      plVar2 = (longlong *)*plVar2;
      while (cVar1 == '\0') {
        cVar1 = *(char *)(*plVar2 + 0x19);
        plVar5 = plVar2;
        plVar2 = (longlong *)*plVar2;
      }
    }
    else {
      cVar1 = *(char *)(plVar5[1] + 0x19);
      plVar3 = (longlong *)plVar5[1];
      plVar2 = plVar5;
      while ((plVar5 = plVar3, cVar1 == '\0' && (plVar2 == (longlong *)plVar5[2]))) {
        cVar1 = *(char *)(plVar5[1] + 0x19);
        plVar3 = (longlong *)plVar5[1];
        plVar2 = plVar5;
      }
    }
    cVar1 = *(char *)((longlong)plVar5 + 0x19);
  }
  return iVar4;
}

