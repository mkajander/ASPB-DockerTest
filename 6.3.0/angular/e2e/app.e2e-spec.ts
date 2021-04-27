import { DockerTestTemplatePage } from './app.po';

describe('DockerTest App', function() {
  let page: DockerTestTemplatePage;

  beforeEach(() => {
    page = new DockerTestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
