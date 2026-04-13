FUNCTION: GolfIn::YoloClubSegmentation::loadModel
ENTRY: 180085380
REASONS: name:club


/* public: virtual bool __cdecl GolfIn::YoloClubSegmentation::loadModel(void) __ptr64 */

bool __thiscall GolfIn::YoloClubSegmentation::loadModel(YoloClubSegmentation *this)

{
  int *piVar1;
  Net *this_00;
  undefined8 *puVar2;
  undefined8 *puVar3;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_18 [16];
  
                    /* 0x85380  785  ?loadModel@YoloClubSegmentation@GolfIn@@UEAA_NXZ */
  puVar2 = (undefined8 *)cv::dnn::dnn4_v20240521::readNetFromONNX(local_18);
  puVar3 = (undefined8 *)FUN_1801327e0(0x10);
  *puVar3 = 0;
  puVar3[1] = 0;
  if (puVar2[1] != 0) {
    LOCK();
    piVar1 = (int *)(puVar2[1] + 8);
    *piVar1 = *piVar1 + 1;
    UNLOCK();
  }
  *puVar3 = *puVar2;
  puVar3[1] = puVar2[1];
  this_00 = *(Net **)(this + 0x48);
  *(undefined8 **)(this + 0x48) = puVar3;
  if (this_00 != (Net *)0x0) {
    cv::dnn::dnn4_v20240521::Net::~Net(this_00);
    free(this_00);
  }
  cv::dnn::dnn4_v20240521::Net::~Net((Net *)local_18);
  cv::dnn::dnn4_v20240521::Net::setPreferableBackend(*(Net **)(this + 0x48),5);
  cv::dnn::dnn4_v20240521::Net::setPreferableTarget(*(Net **)(this + 0x48),6);
  cv::dnn::dnn4_v20240521::Net::enableWinograd(*(Net **)(this + 0x48),true);
  cv::dnn::dnn4_v20240521::Net::enableFusion(*(Net **)(this + 0x48),true);
  return true;
}

