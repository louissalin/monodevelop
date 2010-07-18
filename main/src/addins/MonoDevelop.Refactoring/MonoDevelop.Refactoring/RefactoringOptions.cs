// 
// RefactoringOptions.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using MonoDevelop.Projects.Dom.Parser;
using MonoDevelop.Projects.Dom;
using MonoDevelop.Ide.Gui;
 
using System.Text;
using MonoDevelop.Projects.Text;
using ICSharpCode.NRefactory.Ast;
using MonoDevelop.Ide;

namespace MonoDevelop.Refactoring
{
	public class RefactoringOptions
	{
		public ProjectDom Dom {
			get;
			set;
		}
		
		public Document Document {
			get;
			set;
		}
		
		public MonoDevelop.Projects.Dom.INode SelectedItem {
			get;
			set;
		}
		
		public ResolveResult ResolveResult {
			get;
			set;
		}
		
		// file provider for unit test purposes.
		public ITextFileProvider TestFileProvider {
			get;
			set;
		}
		
		public string MimeType {
			get {
				return DesktopService.GetMimeTypeForUri (Document.FileName);
			}
		}
		
		public Mono.TextEditor.TextEditorData GetTextEditorData ()
		{
			return Document.TextEditorData;
		}
		
		public INRefactoryASTProvider GetASTProvider ()
		{
			return RefactoringService.GetASTProvider (MimeType);
		}
		
		public IResolver GetResolver ()
		{
			MonoDevelop.Projects.Dom.Parser.IParser domParser = GetParser ();
			if (domParser == null)
				return null;
			return domParser.CreateResolver (Dom, Document, Document.FileName);
		}
		
		public MonoDevelop.Projects.Dom.Parser.IParser GetParser ()
		{
			return ProjectDomService.GetParser (Document.FileName);
		}
		
		public ICSharpCode.NRefactory.Ast.INode ParseMember (IMember member)
		{
			if (member == null || member.BodyRegion.IsEmpty)
				return null;
			INRefactoryASTProvider provider = GetASTProvider ();
			if (provider == null) 
				return null;
			
			int start = Document.TextEditorData.Document.LocationToOffset (member.BodyRegion.Start.Line - 1, member.BodyRegion.Start.Column - 1);
			int end = Document.TextEditorData.Document.LocationToOffset (member.BodyRegion.End.Line - 1, member.BodyRegion.End.Column - 1);
			string memberBody = Document.TextEditorData.GetTextBetween (start, end);
			return provider.ParseText (memberBody);
		}
		
		public static string GetWhitespaces (Document document, int insertionOffset)
		{
			StringBuilder result = new StringBuilder ();
			for (int i = insertionOffset; i < document.TextEditorData.Length; i++) {
				char ch = document.TextEditorData.GetCharAt (i);
				if (ch == ' ' || ch == '\t') {
					result.Append (ch);
				} else {
					break;
				}
			}
			return result.ToString ();
		}
		
		public static string GetIndent (Document document, IMember member)
		{
			return GetWhitespaces (document, document.TextEditorData.Document.LocationToOffset (member.Location.Line - 1, 0));
		}
		public string GetWhitespaces (int insertionOffset)
		{
			return GetWhitespaces (Document, insertionOffset);
		}
		
		public string GetIndent (IMember member)
		{
			return GetIndent (Document, member);
		}
		
		public IReturnType ShortenTypeName (IReturnType fullyQualifiedTypeName)
		{
			return Document.ParsedDocument.CompilationUnit.ShortenTypeName (fullyQualifiedTypeName, Document.TextEditorData.Caret.Line + 1, Document.TextEditorData.Caret.Column + 1);
		}
		
		public ParsedDocument ParseDocument ()
		{
			return ProjectDomService.Parse (Dom.Project, Document.FileName, Document.TextEditorData.Text);
		}
	}
}
