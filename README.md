# ゲームプログラミング1年(2023年度入学生)

- [シラバス](https://drive.google.com/file/d/1J4VaBPuo8JBVXzrt6RhHy2z69VR1mAGj/view?usp=sharing)
- [Google Meet](https://meet.google.com/bwb-njcm-udh)
- [Slack](https://datgm23.slack.com)
- [木曜 講義日程](thu.md)
- [書く教科書の作例](https://github.com/datgm23/csharp-manual)
- その他
  - [VisualStudioのプロジェクトをGitHubにPublishする](https://github.com/datgm21/gp1/wiki/VisualStudio%E3%81%AE%E3%83%97%E3%83%AD%E3%82%B8%E3%82%A7%E3%82%AF%E3%83%88%E3%82%92GitHub%E3%81%ABPublish%E3%81%99%E3%82%8B)
  - [UnityのプロジェクトをGitで管理するように設定して、GitHubにPublishする手順](https://github.com/datgm22/design/blob/main/github-unity.md)
  - [プロジェクトの更新をGitHubに反映させる](https://github.com/datgm21/gp1/wiki/%E3%83%97%E3%83%AD%E3%82%B8%E3%82%A7%E3%82%AF%E3%83%88%E3%81%AE%E6%9B%B4%E6%96%B0%E3%82%92GitHub%E3%81%AB%E5%8F%8D%E6%98%A0%E3%81%95%E3%81%9B%E3%82%8B)
  - [昨年度の講義資料](https://github.com/datgm22/gp1)

## 参考資料
- [Unity Learning Materials](https://learning.unity3d.jp/)
- [Unityの動作環境](https://am1.jp/tutorials/unity/spec/)
- [Unityブログ. ゲームプログラミングパターンでコードをレベルアップさせよう](https://blog.unity.com/ja/games/level-up-your-code-with-game-programming-patterns)
- [Unityのインストール](https://am1.jp/tutorials/unity/install/)
  - 現在の学校のバージョンはUnity2021.3.4f1
- [Paizaラーニング C#](https://paiza.jp/works/cs/primer)
- [Unityスタッフのブックマーク](https://note.com/unityjapan/m/m5978b902c2b5)
- [ハーバード大学 CS50 の日本語版翻訳プロジェクトのページ](https://cs50.jp/)
- [Unityでのモノの動かし方](https://docs.google.com/document/d/1Su0trfKxB2iLfGdxt1s7pJr76NFwqwdw-pbDhaCrtvE/)
- [テキストファイルの利用](https://docs.google.com/document/d/1Ib6CJYLswOD1y0lAsdagWwtoD0b1Pap4nMtrpdflqV8/)
- [Koji Kita. 今年もミクシィの22新卒技術研修の資料と動画を公開します！](https://mixi-developers.mixi.co.jp/22-technical-training-5fc362a9dc41)
- [北村愛実. Ｕｎｉｔｙの教科書 はじめてでも安心！ Ｕｎｉｔｙ ２０２２完全対応版](https://honto.jp/netstore/pd-book_31664182.html)
- 内藤時浩. プログラミング指南-ゲーム制作
  - [内藤時浩. ゲーム制作の現場](https://codeknowledge.livedoor.blog/archives/12945552.html)
  - [内藤時浩. ゲーム制作のデバッグ](https://codeknowledge.livedoor.blog/archives/13051282.html)
  - [内藤時浩. ゲーム制作のWBS分解](https://codeknowledge.livedoor.blog/archives/12980840.html)
  - [内藤時浩. ゲーム制作の工数設定](https://codeknowledge.livedoor.blog/archives/12988411.html)
  - [内藤時浩. ゲーム制作のプロジェクト管理](https://codeknowledge.livedoor.blog/archives/13027501.html)
  - [内藤時浩. ゲーム制作の工数最適化](https://codeknowledge.livedoor.blog/archives/13048099.html)
- [内藤時浩. C言語001 基礎講座連載開始](https://codeknowledge.livedoor.blog/archives/17082816.html)  

## 4回目(5/18)

### 話題
- [Unreal Engine5.2 リリース](https://www.unrealengine.com/ja/blog/unreal-engine-5-2-is-now-available)
  - [alwei. UE5.2の気になる情報ツイート](https://twitter.com/aizen76/status/1656821935966416897)
- [Epic Games Storeでゲームをリリース](https://store.epicgames.com/ja/news/epic-games-store-launches-self-publishing-tools-for-game-developers-and-publishers)
- [ゲームメーカーズ. Google、現実世界の地理座標とリンクしたARコンテンツを作成できるツール『Geospatial Creator』を発表。UnityとAdobe Aeroで利用可能](https://gamemakers.jp/article/2023_05_11_38671/)
  - [developers.google.com Unity用Geospatial Creatorを使ってみる](https://developers.google.com/codelabs/arcore-unity-geospatial-creator?hl=ja#0)
- [developers.google.com フォトリアリスティック3Dタイルの概要](https://developers.google.com/maps/documentation/tile/3d-tiles-overview?hl=ja)

### 復習問題
「書く教科書」とGitHubの使い方ののドキュメントを参照して、以下の手順に従ってVisusl C#プロジェクトを作成して、GitHubへ公開せよ。

※自分で作成した書く教科書がない場合は[こちら](https://github.com/datgm23/csharp-manual)を参照する。

1. Visual C#の新規プロジェクトを作成して、名前を`fukuv0518`にする
1. GitHubにPublishする
   - 参考 [VisualStudioのプロジェクトをGitHubにPublishする](https://github.com/datgm21/gp1/wiki/VisualStudio%E3%81%AE%E3%83%97%E3%83%AD%E3%82%B8%E3%82%A7%E3%82%AF%E3%83%88%E3%82%92GitHub%E3%81%ABPublish%E3%81%99%E3%82%8B)
1. ボタンを3つ配置する
1. 1つ目のボタンに「氏名」と表示する。そのボタンをクリックすると、そのボタンの表示が自分の名前に変わるようにする
1. 2つ目のボタンに「左」と表示して、フォームの中央辺りに配置する。そのボタンをクリックすると、そのボタンがフォームの左端に移動するようにする
1. 3つ目のボタンに「消える」と表示する。そのボタンをクリックすると、そのボタンが消えるようにする
1. プロジェクトの更新をGitHubに反映させる
   - 参考 [プロジェクトの更新をGitHubに反映させる](https://github.com/datgm21/gp1/wiki/%E3%83%97%E3%83%AD%E3%82%B8%E3%82%A7%E3%82%AF%E3%83%88%E3%81%AE%E6%9B%B4%E6%96%B0%E3%82%92GitHub%E3%81%AB%E5%8F%8D%E6%98%A0%E3%81%95%E3%81%9B%E3%82%8B)

#### おまけ
上記ができて時間が余った人は、以下のようなことにも取り組んでみよう。成果物は、GitHubでPushすれば更新される。

- 新しいボタンを作って、クリックすると色が変わるようにする
- ラベルを作って、クリックすると表示が変わるようにする
- その他、思いついたことを実装

### 予定
- 計算 / コントロールの表現を増やす


## 3回目(5/11)

### 話題
- [RPG Maker Unite](https://assetstore.unity.com/packages/2d/gui/rpg-maker-unite-please-read-the-description-about-early-bird-bon-253689#publisher)
- [Unreal Editor for Fortnite (UEFN)](https://dev.epicgames.com/documentation/ja-jp/uefn/unreal-editor-for-fortnite-documentation)

### 復習問題
「書く教科書」を参照して、以下の手順に従ってVisusl C#プロジェクトを作成して、Visual StudioのスクリーンショットをSlackに貼り付けよ。

※自分で作成した書く教科書がない場合は[こちら](https://github.com/datgm23/csharp-manual)を参照する。

1. Visual C#の新規プロジェクトを`fukuv0511`という名前で作成する
1. ボタンを2つ置く
1. 1つ目のボタンを押したら、自分の氏名をメッセージボックスで表示
1. 2つ目のボタンを押したら、モニターのシールに`A601-00`というように書かれている文字列をメッセージボックスで表示
1. 実装が完了したら[Slack](https://datgm23.slack.con)を開いてGoogleアカウントでログインする

プログラムを開始して、1つ目のボタンを押してメッセージが表示されている画面のスクリーンショットを撮ってSlackの自分のチャンネルに貼り付ける。2つ目のボタンを押した時の画面も同様に貼り付けて送信する。

スクリーンショットの撮り方

1. Windowsキー + Shiftキー + Sキーを押してスクリーンショットメニューを表示して、**全画面表示の領域切り取り**をクリック
1. 貼り付けたい場所をクリックで選択して、Ctrlキー + Vキー

### 内容
- 前回までの振り返り
- プロパティ / 計算
  - GitHubを開く > Sign in > csharp-manual を開く
  - Visual C#で`v0511`という名前で新しいプロジェクトを作成
  - [VisualStudioのプロジェクトをGitHubにPublishする](https://github.com/datgm21/gp1/wiki/VisualStudio%E3%81%AE%E3%83%97%E3%83%AD%E3%82%B8%E3%82%A7%E3%82%AF%E3%83%88%E3%82%92GitHub%E3%81%ABPublish%E3%81%99%E3%82%8B)
- [プロジェクトの更新をGitHubに反映させる](https://github.com/datgm21/gp1/wiki/%E3%83%97%E3%83%AD%E3%82%B8%E3%82%A7%E3%82%AF%E3%83%88%E3%81%AE%E6%9B%B4%E6%96%B0%E3%82%92GitHub%E3%81%AB%E5%8F%8D%E6%98%A0%E3%81%95%E3%81%9B%E3%82%8B)


## 2回目

### 復習問題
前回作成した「書く教科書」を参照して、以下の手順に従ってVisusl C#プロジェクトを作成して、Visual StudioのスクリーンショットをSlackに貼り付けよ。

※自分で作成した書く教科書がない場合は[こちら](https://github.com/datgm23/csharp-manual/blob/master/01.md)を参照する。

1. 書く教科書の手順に従ってVisual Studioを起動する
1. 新しいC#のプロジェクトを`cs0420`という名前で作成する
1. プロジェクトが起動したら開始する
1. Windowsキー + Shiftキー + Sキーを押してスクリーンショットメニューを表示して、**全画面表示の領域切り取り**をクリック
1. https://datgm23.slack.com を開く
1. 学校で作成したGoogleアカウントでSlackにサインイン
1. 「#times_自分の名前」のチャンネルにCtrlキー + Vキーでスクリーンショットを貼り付けて、メッセージを送信する

### 内容
- 書く教科書01の復習と続き
  - Visual Studioの基本操作 / 問題の解消
  - [書く教科書の作例](https://github.com/datgm23/csharp-manual)
- Unityの動作確認
- 独習
  - [Unity Learning Materials](https://learning.unity3d.jp/)
  - [Paizaラーニング C#](https://paiza.jp/works/cs/primer)
    - アカウントをGitHubで登録
  - プログラミング関連の良質な記事が日々増えているので、よいサイトを探してみてください！


## 1回目

### 話題
- [Webブラウザやスマホでノーコーディングでゲームが作れるGDevelop](https://gdevelop.io/ja-jp)
- [Unityの動作環境](https://am1.jp/tutorials/unity/spec/)

### 内容

- ガイダンス
  - [プログラミングを学ぶ前に](https://docs.google.com/presentation/d/1mIIrnua1nf2yCiXA6KMkTUOylzPIxiUCeqQEdtHdPhc/)
- [環境の準備](https://docs.google.com/document/d/16MW6maMYvt8m-60RM5wU_LzJ5r-3Hm0WTnxoBGDzxIA/)
  - Googleアカウント / Slack / GitHub / 作業用フォルダー
  - ツールについて
    - プログラムやアプリの使い方の管理、文章作成者が決まっているようなもの：GitHub
    - 大きな画像や動画など：Googleドライブ
    - 意見交換が主体。3ヶ月で消えるので消えてもよい質疑応答や進捗の共有、ブレストなど。クラス以外には非公開：Slack
    - 企画書や仕様書、確認事項など、手軽に共有したり編集できて残しておきたい文章：Googleドキュメント、ワークシート、Notion, Trelloなど
- [講義メモ](https://docs.google.com/document/d/1olAvmpehNVCLBdf329Ubas7FgygtEqyk5j9nyE-rTEI/)
    - Visual C# / Unity

