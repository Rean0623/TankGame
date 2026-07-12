using UnityEngine;
public class 记录音乐和音效 : MonoBehaviour
{
    
    public static void PlaySFX(AudioClip clip, Vector3 position)//AudioClip代表音频 V3是位置
                                                                //一个静态方法不需要实例化对象也能用
    {
        if (clip == null) return;//防御性编程，如果没穿进来这个音频什么也不发生

        float volume = 1f; // 默认音量,以防shezhi还没初始化

        if (主页的设置界面.instance != null)
        {
            volume = 主页的设置界面.instance.is2 ? 主页的设置界面.instance.nowValue2 : 0f;
            //写法和这个if语句一样
//            if (主页的设置界面.instance.is2)
//            {
//                volume = 主页的设置界面.instance.nowValue2;
//            }
//            else
//            {
//                volume = 0f;
//            }
        }

        AudioSource.PlayClipAtPoint(clip, position, volume);//.PlayClipAtPoint为静态方法
                                                            //专门为"一次性音效"设计的便捷API
                                                            //clip: 放哪段声音。
                                                            //position: 在哪个坐标位置发出(影响3D空间音效)。
                                                            //volume: 上面算出来的最终音量值。
    }
}

