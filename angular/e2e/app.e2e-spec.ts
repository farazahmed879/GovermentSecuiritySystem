import { GovermentSecuritySystemAppTemplatePage } from './app.po';

describe('GovermentSecuritySystemApp App', function() {
  let page: GovermentSecuritySystemAppTemplatePage;

  beforeEach(() => {
    page = new GovermentSecuritySystemAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
