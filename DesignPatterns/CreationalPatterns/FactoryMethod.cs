using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
    /// https://www.dofactory.com/net/factory-method-design-pattern
    /// </summary>
    abstract class Page
    {
    }

    class SkillsPage : Page
    {

    }

    class EducationPage : Page
    {

    }

    class ExperiencePage: Page
    {

    }

    class IntroductionPage : Page
    {

    }

    class ResultsPage : Page
    {
    }

    class ConclusionPage: Page
    {

    }

    class SummaryPage: Page
    {

    }

    class BibliographyPage: Page
    {

    }

    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }
        public abstract void CreatePages();
    }


    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }

    }

    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
