namespace Define
{
    public static class GlobalConfig
    {
        public static string[] SnakeDialog = new[]
        {
            "嘶嘶嘶嘶嘶",
            "庸医，最近“不能笑”病毒蔓延于地狱，搅乱了恶魔们的脑内神经。",
            "地狱的恶魔们无法通过任何的方式感受到快乐，吞食再多的灵魂也没有效果。",
            "虽然我知道你的医术不怎么样，但你是地狱里唯一的神经外科主任了，",
            "嘶，这下恶魔们都得来找你来治疗他们的大脑了。",
            "嘶~第一个客人就来了！",
            "嘶，可别搞砸了！这可是提高你在地狱地位的好机会！",
            //成功下一波
            "还不赖嘛庸医，看来你还没有愚蠢到忘记自己的手艺。",
            "嘶~第二位客人来了。",
            "我已经嗅到了暴躁的气息",
            "不过我相信凭借你成熟的工作经验，一定可以完美应对的！",
            //撒旦成功后
            "嘶~天哪你治好了撒旦，我们这辈子都不用愁吃穿了，",
            "我以后每天都要吃一个亚当的苹果。",
        };

        public static string DuYanFail = "看来没有在限时的时间内完成，使他的神经错乱了。";
        public static string DogFail = "看来没有在限时的时间内完成，引燃傻狗们的喷火神经了。";
        public static string SaDanFail = "看来没有在限时时间里完成神经恢复，导致这位显赫的主人，地狱里的王，恶魔里的最强神经错乱了。";
        public static string[] DuYanCorrectDialog = new[]
        {
            "医生，我一眼就看出来你不是庸医。",
            "麻烦您竭尽全力将我治好吧。我不能一直一板一眼地面对我的上司。",
            "这有损我作为地狱领主秘书职位的风度。",
            //成功下一波
            "撒旦啊！这下你会高看我一眼了吧。",
            "（对你鞠躬）谢谢您，医术高明的主任先生。",
        };
        public static string[] DuYanErrorDialog = new[]
        {
            "（一只眼里狂流泪水）发生了什么？",
            "为什么我控制不了地开始哭泣？！",
        };

        public static string[] DogCorrectDialog = new[]
        {
            "汪！！呜汪——！（口露獠牙、眼露凶光地看着你）",
            "撕咬，我要撕咬一切！",
            "什么撕咬！我们来这里是要治病！我们要对主人笑！",
            "谁敢惹怒我们地狱三头犬的主人，我们会把他咬碎成拼不起来的碎片！",
            //成功下一波
            "呜汪...看来你确实有两把刷子...汪.....",
            "（三只头狗之间交头接耳窃窃私语）",
            "汪！我们尊贵的主人，地狱里的王，恶魔里的最强，显赫的首领，",
            "将来找你治病。",
            "如果你治不好，（想做出凶狠的表情但因笑声失败），我们就，把你咬碎！",
        };
        public static string[] DogErrorDialog = new[]
        {
            "我们的头怎么撞一块了？！",
            "呜呜，嗷呜。（泪眼汪汪地看着你想等待摸摸）",
        };
        
        public static string[] SaDanCorrectDialog = new[]
        {
            "你就是那个治疗“不能笑”病毒的医生？我是……",
            "......",
            "三天后我的女儿将在地狱举办有史以来最为盛大的婚礼，",
            "然而因为“不能笑”病毒，我无法在我女儿的婚礼上展现笑容。",
            "这是我不能允许的。",
            "我的秘书、坐骑守卫，都已在你这里医治好了病毒。庶民，我需要你即刻帮我治疗好我的病毒。",
            //成功下一步
            "哈哈哈哈…凡人，你的实力得到了认可",
            //蛇对话后
            "哈哈哈哈，你以为你真的治好了撒旦吗？那你可太单纯了！伟大的撒旦，伟大的主人，他的大脑怎么会如此单纯！我不过是他的替身，下面有请真正的万魔之主，撒旦！",
        };
        public static string[] SaDanErrorDialog = new[]
        {
            "（哭泣）你做了什么？",
            "（呜呜哭泣）我有罪，我弄碎了家具…我有罪。",
            "（害羞）你做了什么？为什么我双颊发红，心跳加速，眼冒桃心？",
        };
    }
}