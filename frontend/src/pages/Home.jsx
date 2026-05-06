import React, { useEffect, useMemo, useState } from 'react';
import { FiArrowRight, FiChevronLeft, FiChevronRight, FiCode, FiSearch } from 'react-icons/fi';
import { useNavigate } from 'react-router-dom';
import Card from '../components/Card';
import { DETAILS_PREFIX } from '../constants/ROUTES';
import { EASY, HARD, MEDIUM } from '../constants/MISC';
import { PROBLEMS } from '../constants/PROBLEMS';
import PageContainer from '../layout/PageContainer';
import ProblemFilter from '../layout/ProblemFilter';
import '../styles/page.css';
import './Home.css';

const ALL_DIFFICULTIES = 'all';
const PAGE_SIZE = 9;

const getProblemPreview = (description) => {
	const normalizedDescription = description.replace(/\s+/g, ' ').trim();

	if (normalizedDescription.length <= 140) return normalizedDescription;

	return `${normalizedDescription.slice(0, 140)}...`;
};

const Home = () => {
	const navigate = useNavigate();
	const [difficulty, setDifficulty] = useState(ALL_DIFFICULTIES);
	const [searchTerm, setSearchTerm] = useState('');
	const [page, setPage] = useState(1);

	const counts = useMemo(
		() => ({
			[ALL_DIFFICULTIES]: PROBLEMS.length,
			[EASY]: PROBLEMS.filter((problem) => problem.difficulty === EASY).length,
			[MEDIUM]: PROBLEMS.filter((problem) => problem.difficulty === MEDIUM).length,
			[HARD]: PROBLEMS.filter((problem) => problem.difficulty === HARD).length
		}),
		[]
	);

	const filteredProblems = useMemo(() => {
		const normalizedSearchTerm = searchTerm.trim().toLowerCase();

		return PROBLEMS.filter((problem) => {
			const matchesDifficulty =
				difficulty === ALL_DIFFICULTIES || problem.difficulty === difficulty;
			const matchesSearch =
				normalizedSearchTerm.length === 0 ||
				problem.title.toLowerCase().includes(normalizedSearchTerm) ||
				problem.number.toString().includes(normalizedSearchTerm);

			return matchesDifficulty && matchesSearch;
		}).sort((left, right) => left.number - right.number);
	}, [difficulty, searchTerm]);

	const pageCount = Math.max(1, Math.ceil(filteredProblems.length / PAGE_SIZE));
	const firstProblemOnPage = (page - 1) * PAGE_SIZE;
	const paginatedProblems = filteredProblems.slice(firstProblemOnPage, firstProblemOnPage + PAGE_SIZE);

	useEffect(() => {
		setPage(1);
	}, [difficulty, searchTerm]);

	useEffect(() => {
		if (page <= pageCount) return;

		setPage(pageCount);
	}, [page, pageCount]);

	const handlePageDecrease = () => {
		setPage((previousPage) => Math.max(1, previousPage - 1));
	};

	const handlePageIncrease = () => {
		setPage((previousPage) => Math.min(pageCount, previousPage + 1));
	};

	return (
		<div className='page home-page'>
			<PageContainer>
				<Card extraClassNames={['hero-card', 'fullwidth']}>
					<div className='hero-copy'>
						<span className='eyebrow'>C# practice library</span>
						<h1 className='title'>Leetcode Solutions</h1>
						<p className='paragraph'>
							A searchable collection of solved problems with the prompt, my approach, and the
							C# implementation kept together for quick review.
						</p>
					</div>

					<div className='hero-metrics' aria-label='Solution counts'>
						<div className='metric-pill'>
							<strong>{counts[ALL_DIFFICULTIES]}</strong>
							<span>Total</span>
						</div>
						<div className='metric-pill easy'>
							<strong>{counts[EASY]}</strong>
							<span>Easy</span>
						</div>
						<div className='metric-pill medium'>
							<strong>{counts[MEDIUM]}</strong>
							<span>Medium</span>
						</div>
						<div className='metric-pill hard'>
							<strong>{counts[HARD]}</strong>
							<span>Hard</span>
						</div>
					</div>
				</Card>

				<section className='solution-toolbar card' aria-label='Solution filters'>
					<label className='search-control'>
						<FiSearch aria-hidden='true' />
						<input
							type='search'
							value={searchTerm}
							placeholder='Search title or number'
							onChange={(event) => setSearchTerm(event.target.value)}
						/>
					</label>

					<ProblemFilter
						activeDifficulty={difficulty}
						counts={counts}
						handleFilterClick={setDifficulty}
					/>
				</section>

				<div className='results-heading'>
					<div>
						<span className='eyebrow'>Solutions</span>
						<h2 className='title secondary'>{filteredProblems.length} results</h2>
					</div>
					<span className='page-indicator'>
						Page {page} of {pageCount}
					</span>
				</div>

				{paginatedProblems.length > 0 ? (
					<div className='problem-container'>
						{paginatedProblems.map((problem, index) => (
							<button
								key={problem.number}
								type='button'
								className={`problem-box ${problem.difficulty}`}
								onClick={() => navigate(`${DETAILS_PREFIX}/${problem.number}`)}
								style={{ animationDelay: `${index * 0.05}s` }}
							>
								<div className='problem-card-header'>
									<span className='problem-box-number'>#{problem.number}</span>
									<span className={`difficulty-badge ${problem.difficulty}`}>
										{problem.difficulty}
									</span>
								</div>

								<h3 className='title secondary'>{problem.title}</h3>
								<p>{getProblemPreview(problem.description)}</p>

								<div className='problem-card-footer'>
									<span>
										<FiCode aria-hidden='true' />
										C#
									</span>
									<span>
										View
										<FiArrowRight aria-hidden='true' />
									</span>
								</div>
							</button>
						))}
					</div>
				) : (
					<Card extraClassNames={['fullwidth', 'empty-state']}>
						<h3 className='title secondary'>No solutions found</h3>
						<p className='paragraph'>Try a different title, number, or difficulty.</p>
					</Card>
				)}

				{pageCount > 1 && (
					<div className='problem-pagination'>
						<button
							type='button'
							className='pagination-button'
							onClick={handlePageDecrease}
							disabled={page <= 1}
							aria-label='Previous page'
						>
							<FiChevronLeft aria-hidden='true' />
						</button>
						<button
							type='button'
							className='pagination-button'
							onClick={handlePageIncrease}
							disabled={page >= pageCount}
							aria-label='Next page'
						>
							<FiChevronRight aria-hidden='true' />
						</button>
					</div>
				)}
			</PageContainer>
		</div>
	);
};

export default Home;
