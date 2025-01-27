# GitHub Copilotを使ったAIペアプログラミング
LinkedInラーニングの「GitHub Copilotを使ったAIペアプログラミング」コース用のリポジトリです。このコースは [LinkedInラーニング][lil-course-url]で視聴できます。

![course-name-alt-text][lil-thumbnail-url] 

ペアプログラミングとは２人組になりプログラミンを行う手法です。GitHub Copilotを利用することでAIと対話しながらペアプログラミングを行うことができます。このコースではGitHub Copilotを利用してWebアプリケーションを作成します。まずGitHub Copilotやペアプログラミングの概要を解説します。そしてGitHub Copilotを利用したプロジェクトの作成や、サーバーサイドのC#を使ったプログラミング、そしてフロントサイドのHTMLとJavaScriptで記述を行う方法を実演形式で紹介します。このコースを受講することで、GitHub Copilotを利用したアプリケーション開発の便利さを学ぶことができるでしょう。

## リポジトリの使い方
このリポジトリには必要に応じてブランチが設けられています。ブランチのポップアップメニューを使用して、使用するブランチに切り替えたあとにコースを視聴してください。またURLに`「/tree/ブランチ名」`を追加することで、アクセスしたいブランチに移動することも可能です。

## ブランチ
ブランチはレッスンごとに作成されている場合があります。その場合はブランチ名に`「章番号_レッスン番号」`が付けられています。例えば`「02_03」`という名前のブランチは、2章の上から3番目のレッスン用のブランチとなります。

レッスン前と後のコードを格納しているブランチもあります。該当ブランチには「開始時」（beginning）を表す`「b」`と、「終了時」（ending）を表す`「e」` がブランチ名についています。`「b」`のブランチにはレッスン開始時点のコードが、`「e」`のブランチにはレッスン終了時点のコードが格納されています。また「main」のブランチにはコードの最終形が格納されています。

ファイルに変更を加えた後に、エクササイズファイルのブランチを次のブランチに切り替えたさい、次のようなメッセージが表示されることがあります。

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

この問題を解決するには：
	
    次のコマンドで変更を加えます：git add .
	次のコマンドで変更をコミットします：git commit -m "some message"

 ## GitHub Codespacesについて
プログラミング言語を学ぶ最良の方法は、実際にそれを使用することです。それがこのコースがGitHub Codespacesと統合されている理由です。GitHub Codespacesは、あなたが普段使っているIDEのすべての機能を提供するクラウド上の手軽な開発環境です。ローカルマシンのセットアップも必要ありません。 GitHub Codespacesを使えば、あなたが職場で使っている他のツールを使用しながら、どのパソコンからでもいつでもプログラミングの実践的な練習ができます。

## インストラクター

西村誠

プログラマー、Microsoft MVP


[0]: # (Replace these placeholder URLs with actual course URLs)

[lil-course-url]: https://www.linkedin.com/learning/ai-pair-programming-with-github-copilot-24016247
[lil-thumbnail-url]: https://media.licdn.com/dms/image/D4D0DAQH80lCwjjcNyg/learning-public-crop_675_1200/0/1718137261511?e=2147483647&v=beta&t=9oQuWU5MERlKMwoY2YmlJiQT4DXgqNGZLU4-jPjmJMo

