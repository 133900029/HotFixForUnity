using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LuaInterface;
using SLua;
public class ui : MonoBehaviour {

	// Use this for initialization

    LuaSvr luaSvr;
	void Start () {
        luaSvr = new LuaSvr();
        luaSvr.init(null, () =>
        {
            luaSvr.start("uiLua");
        }, LuaSvrFlag.LSF_DEBUG);
 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

//canvas
//screen space - overlay
//自动根据窗口大小修改ui，rect transform 不能被修改
//pixel perfect 使 ui元素渲染输出的时候会自动吸附到最近的像素点，达到增强ui的效果
//*ui和camera无关，ui永远在最顶

//screen space - camera
//和第一个差不多，只不过是由场景中指定的摄像机渲染输出
//使用摄像机来对ui进行渲染输出，摄像机的设定会影响ui
//plane distance 用来设置 ui渲染 锥形camera 的大小
//*ui和camera相关，camera移动会影响ui，ui跟随camera移动

//world space
//相当于ui挂在object上
//event camera 用来接收事件
//receives event 表示canvas里面的ui元素是否接受事件
//sortinglayer和orderInlayer用来控制canvas之间的渲染顺序
//*ui和camera相关，camera移动会影响ui，ui不跟随camera移动，ui相当于一个3d object

//ui的渲染顺序是根据ui在hierarchy的顺序
//第一个会渲染在最底，第二个会渲染在上面


//RectTransform
//相对于父对象锚点（mao）
//绕锚点旋转
//（0，0）在左下方，（1，1）在右上方
//blueprint模式可以在Rect Transform不被旋转和缩放下进行编辑
//在row模式下，修改anchor 会影响ui的大小

//anchor 为三角形
//pivot  为圆形

//anchor是相对于父对象的锚点(0,0)是父类的左下角
//pivot是相对于自己的中心点(0,0)是自己的左下角

//当anchors 的min x和max x 一样的时候
//显示为pos x 和 width ，pos x为 pivot离anchor的距离
//同理anchors的min y和max y 一样的时候
//显示为pos y 和 height ，pox y 为pivot离anchor的距离

//当anchors 的min x和max x 不一样的时候
//Left 为子对象左边框线离 anchor 的左边框线距离
//Right为子对象右边框线离 anchor 的右边框线距离

//当anchors 的min y和max y 不一样的时候
//Top    为子对象上边框线离 anchor 的上边框线距离
//Bottom 为子对象下边框线离 anchor 的下边框线距离

//图形快捷
//直接点击为父对象anchor
//按着shift 为子对象pivot
//按着ctrl 为子对象position

//anchors 不一样的时候可以实现根据父对象进行缩放
//anchors 一样的时候可以实现在父对象的指定位置